using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMadness
{
    public partial class Leaderboard : Form
    {
        SQLiteConnection conn;
        string connString = "Data Source=MemoryDB.db;Version = 3;";

        Form form;

        public Leaderboard()
        {
            InitializeComponent();
        }
        
        public Leaderboard(Form form)
        {
            InitializeComponent();
            LoadLeaderboard();

            listView1.GridLines = true;
            this.form = form;
        }
        private void LoadLeaderboard()
        {
            conn = new SQLiteConnection(connString);
            conn.Open();
            String selectQuery = "SELECT * FROM users_leaderboard ORDER BY score1 DESC";
            SQLiteCommand cmd = new SQLiteCommand(selectQuery, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] row = { reader.GetString(0), reader.GetInt32(1).ToString(), reader.GetInt32(2).ToString(), reader.GetInt32(3).ToString(), reader.GetInt32(4).ToString(), reader.GetInt32(5).ToString(), reader.GetInt32(6).ToString(), reader.GetInt32(7).ToString(), reader.GetInt32(8).ToString(), reader.GetInt32(9).ToString(), reader.GetInt32(10).ToString() };
                    var listViewItem = new ListViewItem(row);
                    //Hightlight the current player
                    if (reader.GetString(0).Equals(MainMenu.username))
                        listViewItem.ForeColor = Color.Red;
                    listView1.Items.Add(listViewItem);
                }
            }
            conn.Close();
        }      

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }
    }
}
