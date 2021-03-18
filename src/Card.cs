using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMadness
{
    class Card
    {
        public string pictureBoxName;
        public string imagePath;
        public int matchNum;

        public Card(string pictureBoxName, int matchNum, string imagePath)
        {
            this.pictureBoxName = pictureBoxName;
            this.matchNum = matchNum;
            this.imagePath = imagePath;
        }
    }
}
