using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryMadness
{
    class DBController
    {
        SQLiteConnection conn;
        string connString = "Data Source=MemoryDB.db;Version = 3;";

        public void Add(string username, int score)
        {
            conn = new SQLiteConnection(connString);
            SQLiteCommand cmd;
            //SQLiteCommand cmd;
            conn.Open();
            if (!userExists())
            {
                String insertQuery = "INSERT INTO users_leaderboard(username, score1, score2, score3, score4, score5, score6, score7, score8, score9, score10) VALUES(@name, @score, 0, 0 , 0, 0, 0, 0, 0, 0, 0)";
                cmd = new SQLiteCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@name", MainMenu.username);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.Prepare(); //Best practice for safety
                cmd.ExecuteNonQuery();
            }
            else
            {
                //Get all scores of current player from database
                String selectScoresQuery = "SELECT * FROM users_leaderboard WHERE username=@name";
                cmd = new SQLiteCommand(selectScoresQuery, conn);
                cmd.Parameters.AddWithValue("@name", MainMenu.username);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    //Placing scores in array   
                    reader.Read();
                    int[] scores = { reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10) };
                    //Insert the new score and shift the rest left
                    for (int i = 0; i < scores.Length; i++)
                    {
                        if (score > scores[i])
                        {
                            for (int j = scores.Length - 1; j > i; j--)
                                scores[j] = scores[j - 1];
                            scores[i] = score;
                            break;
                        }
                        else if (score == scores[i])
                            break;
                    }
                    reader.Close();
                    //Update database
                    String insertScoreQuery = "UPDATE users_leaderboard SET score1=@score1, score2=@score2, score3=@score3, score4=@score4, score5=@score5, score6=@score6, score7=@score7, score8=@score8, score9=@score9, score10=@score10 WHERE username=@name2";
                    cmd = new SQLiteCommand(insertScoreQuery, conn);
                    cmd.Parameters.AddWithValue("@name2", MainMenu.username);
                    cmd.Parameters.AddWithValue("@score1", scores[0]);
                    cmd.Parameters.AddWithValue("@score2", scores[1]);
                    cmd.Parameters.AddWithValue("@score3", scores[2]);
                    cmd.Parameters.AddWithValue("@score4", scores[3]);
                    cmd.Parameters.AddWithValue("@score5", scores[4]);
                    cmd.Parameters.AddWithValue("@score6", scores[5]);
                    cmd.Parameters.AddWithValue("@score7", scores[6]);
                    cmd.Parameters.AddWithValue("@score8", scores[7]);
                    cmd.Parameters.AddWithValue("@score9", scores[8]);
                    cmd.Parameters.AddWithValue("@score10", scores[9]);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }

        private bool userExists()
        {
            String selectQuery = "SELECT username FROM users_leaderboard WHERE username=@name";
            SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn);
            cmd.Parameters.AddWithValue("@name", MainMenu.username);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
    }
}
