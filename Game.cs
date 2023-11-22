using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToe
{
    public class Game
    {
        private char currentPlayerTurn = 'X';
        public Score PlayerXScore { get; set; }
        public Score PlayerOScore { get; set; }
        public Place[,] board = new Place[3, 3];
        
        public void AddPlaceToBoard(Place place)
        {
            // Add each place to the board
            board[place.Row, place.Column] = place;
        }

        private char CheckWin()
        {
            // Check rows for a win
            for (int i = 0; i < 3; i++)
            {
                if (AreEqual(board[i, 0], board[i, 1], board[i, 2]))
                {
                    return board[i, 0].PlayerSymbol;
                }
            }

            // Check columns for a win
            for (int i = 0; i < 3; i++)
            {
                if (AreEqual(board[0, i], board[1, i], board[2, i]))
                {
                    return board[0, i].PlayerSymbol;
                }
            }

            // Check diagonals for a win
            if (AreEqual(board[0, 0], board[1, 1], board[2, 2]))
            {
                return board[0, 0].PlayerSymbol;
            }

            if (AreEqual(board[0, 2], board[1, 1], board[2, 0]))
            {
                return board[0, 2].PlayerSymbol;
            }

            // No winner
            return ' ';
        }

        private bool AreEqual(Place place1, Place place2, Place place3)
        {
            // Helper method to check if the text of three places is the same
            return place1.PlayerSymbol == place2.PlayerSymbol && place2.PlayerSymbol == place3.PlayerSymbol && place1.PlayerSymbol == place3.PlayerSymbol;
        }

        private void ResetGame()
        {
            // Reset game by reseting buttons and board
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col].ResetPlace();
                }
            }
        }

        private bool CheckForEndGame()
        {
            bool endGame = true;
            // Reset game by reseting buttons and board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i,j].PlayerSymbol == ' ')
                    {
                        endGame = false;
                        break;
                    }
                }
            }

            if (!endGame)
            {
                return endGame;
            }
            
            return endGame;
        }

        public void MakeMove(Place place)
        {
            // Updates button based on button class to the current players move and position
            if (place.PlayerSymbol == ' ')
            {
                place.PlayerSymbol = currentPlayerTurn;
                place.Text = place.PlayerSymbol.ToString();
                place.Font = new Font("Ariel", 15, FontStyle.Regular);

                if (place.PlayerSymbol == 'X')
                {
                    place.BackColor = Color.Blue;
                }
                else if (place.PlayerSymbol == 'O')
                {
                    place.BackColor = Color.Red;
                }
                // Change current players turn
                currentPlayerTurn = (currentPlayerTurn == 'X') ? 'O' : 'X';
                // Check for win and handle win
                char win = CheckWin();
                if (win == 'X')
                {
                    PlayerXScore.UpdateScore();
                    ResetGame();
                }
                else if (win == 'O')
                {
                    PlayerOScore.UpdateScore();
                    ResetGame();
                }
                // Check if no more moves available
                if (CheckForEndGame())
                {
                    ResetGame();
                }
            }
        }
    }
}
