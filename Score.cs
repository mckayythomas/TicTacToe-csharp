using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Score: Label
    {
        public int Points = 0;
        public char Player { set; get; }

        public Score(char player)
        { 
            Player = player;
        }

        public void UpdateScore()
        {
            Points++;
            Text = Points.ToString();
        }

    }
}
