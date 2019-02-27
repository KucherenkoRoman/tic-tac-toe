using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tic_tac_toe
{
    class GameController
    {
        private Button[] fieldButtons;
        private int turn;
        private int Player1Score { get; set; }
        private int Player2Score { get; set; }
        public bool IsGameOver { get; set; } 
        private int numberOfFieldsFilled;
        private int winer;
        TextBox playerTurn;

        public GameController(Button[] fieldButtons, TextBox playerTurn)
        {
            this.fieldButtons = fieldButtons;
            this.turn = 1;
            this.IsGameOver = false;
            this.Player1Score = 0;
            this.Player2Score = 0;
            this.winer = 0;
            this.numberOfFieldsFilled = 0;
            this.playerTurn = playerTurn;
            this.playerTurn.Text = "First player's move";
        }

        public void ClickEvent(int fieldNumber)
        {
            if (IsGameOver)
            {
                Restart();
            }
            else
            {
                if (fieldButtons[fieldNumber].Text == "")
                {
                    FieldClick(fieldNumber);
                    var winComb = WinCheck(fieldNumber);
                    if (winComb.Item1 == -1)
                    {
                        turn = (turn + 1) % 2;
                        if (turn == 1) playerTurn.Text = "First player's move";
                        else playerTurn.Text = "Second player's move";
                        numberOfFieldsFilled++;
                        if (numberOfFieldsFilled == 9)
                        {
                            playerTurn.Text = "Draw!";
                            IsGameOver = true;
                        }
                        return;
                    }
                    else
                    {
                        IsGameOver = true;
                        Color color;
                        if (fieldButtons[winComb.Item1].Text == "X")
                        {
                            winer = 1;
                            Player1Score++;
                            color = Color.PaleGreen;
                            playerTurn.Text = "First player won!";
                        }
                        else
                        {
                            winer = 2;
                            Player2Score++;
                            color = Color.Tomato;
                            playerTurn.Text = "Second player won!";
                        }
                        fieldButtons[winComb.Item1].BackColor = color;
                        fieldButtons[winComb.Item2].BackColor = color;
                        fieldButtons[winComb.Item3].BackColor = color;
                    }
                }
                else return;
            }
        }

        public void FieldClick(int fieldNumber)
        {   
            if (turn == 1)
            {
                fieldButtons[fieldNumber].ForeColor = Color.Green;
                fieldButtons[fieldNumber].Text = "X";
            }
            else
            {
                fieldButtons[fieldNumber].ForeColor = Color.Red;
                fieldButtons[fieldNumber].Text = "O";
            }
        }

        //returns a tuple of field numbers that make up the winning combination
        //else return (-1, -1, -1)
        private (int, int, int) WinCheck(int fieldNumber)
        {
            /*
             *  0 1 2
             *  3 4 5
             *  6 7 8
             * 
             */
            int row = fieldNumber - fieldNumber % 3;
            int col = fieldNumber % 3;
            // check row
            if (fieldButtons[row].Text == fieldButtons[row + 1].Text &&
                fieldButtons[row].Text == fieldButtons[row + 2].Text)
            {
                return (row, row + 1, row + 2);
            }
            //check col
            else if(fieldButtons[col].Text == fieldButtons[col + 3].Text &&
                fieldButtons[col].Text == fieldButtons[col + 6].Text)
            {
                return (col, col + 3, col + 6);
            }
            //check diagonal
            else if (fieldNumber % 2 == 0)
            {
                if(fieldButtons[0].Text == fieldButtons[4].Text &&
                   fieldButtons[0].Text == fieldButtons[8].Text &&
                   fieldButtons[0].Text != "")
                {
                    return (0, 4, 8);
                }
                else if(fieldButtons[2].Text == fieldButtons[4].Text &&
                        fieldButtons[2].Text == fieldButtons[6].Text &&
                        fieldButtons[2].Text != "")
                {
                    return (2, 4, 6);
                }
            }
            return (-1, -1, -1);
        }

        public void Restart()
        {
            foreach (Button field in fieldButtons)
            {
                field.BackColor = Color.White;
                field.Text = "";
            }
            this.turn = 1;
            this.winer = 0;
            this.IsGameOver = false;
            this.numberOfFieldsFilled = 0;
            playerTurn.Text = "First player's move";
        }

        public void StartNewGame()
        {
            foreach (Button field in fieldButtons)
            {
                field.BackColor = Color.White;
                field.Text = "";
            }
            this.turn = 1;
            this.winer = 0;
            this.IsGameOver = false;
            this.numberOfFieldsFilled = 0;
            this.Player1Score = 0;
            this.Player2Score = 0;
            playerTurn.Text = "First player's move";
        }

        public void ShowScore(TextBox Player1ScoreTextBox, TextBox Player2ScoreTextBox)
        {                                               
            Player1ScoreTextBox.Text = $"Player 1 score: {this.Player1Score}";
            Player2ScoreTextBox.Text = $"Player 2 score: {this.Player2Score}";
        }
        
    }
}
