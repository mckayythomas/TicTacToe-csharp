using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Place: Button
    {
        public Game Game;
        public int Row { get; }
        public int Column { get; }
        public char PlayerSymbol { get; set; }

        public Place(Game game, int row, int column)
        {
            Game = game;
            Row = row;
            Column = column;
            PlayerSymbol = ' ';
            Click += OnPlaceClick;
        }

        private void OnPlaceClick(object sender, EventArgs e)
        {
            Game.MakeMove(this);
        }

        public void ResetPlace()
        {
            PlayerSymbol = ' ';
            Text = string.Empty;
            BackColor = SystemColors.ControlDarkDark;
        }
    }
}
