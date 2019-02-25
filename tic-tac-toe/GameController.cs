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
        private int player;
        private int[] winCombination;
        private bool isGameOver;

        public GameController(Button[] fieldButtons)
        {
            this.fieldButtons = fieldButtons;
            this.winCombination = new int[] { -1, -1, -1};
            this.player = 1;
            this.isGameOver = false;
        }

        public void FieldClick(int fieldNumber)
        {
            if (fieldButtons[fieldNumber].Text == "")
            {
                if (player == 1)
                {
                    fieldButtons[fieldNumber].ForeColor = Color.Green;
                    fieldButtons[fieldNumber].Text = "X";
                }
                else
                {
                    fieldButtons[fieldNumber].ForeColor = Color.Red;
                    fieldButtons[fieldNumber].Text = "O";
                }
                player = (player + 1) % 2;
            }
            else return;
            CheckWin(fieldNumber);
            if (isGameOver) Win();

        }

        private void CheckWin(int fieldNumber)
        {
            /*
             *  0 1 2
             *  3 4 5
             *  6 7 8
             * 
             */
            
            int str = fieldNumber - fieldNumber % 3;
            int col = fieldNumber % 3;
            // check row
            if (fieldButtons[str].Text == fieldButtons[str + 1].Text &&
                fieldButtons[str].Text == fieldButtons[str + 2].Text)
            {
                winCombination[0] = str;
                winCombination[1] = str + 1;
                winCombination[2] = str + 2;
                isGameOver = true;
            }
            //check col
            else if(fieldButtons[col].Text == fieldButtons[col + 3].Text &&
                fieldButtons[col].Text == fieldButtons[col + 6].Text)
            {
                winCombination[0] = str;
                winCombination[1] = str + 3;
                winCombination[2] = str + 6;
                isGameOver = true;
            }
            //check diag
            else if(fieldNumber % 2 == 0)
            {
                if(fieldButtons[0].Text == fieldButtons[4].Text &&
                   fieldButtons[0].Text == fieldButtons[8].Text &&
                   fieldButtons[0].Text != "")
                {
                    winCombination[0] = 0;
                    winCombination[1] = 4;
                    winCombination[2] = 8;
                    isGameOver = true;
                }
                else if(fieldButtons[2].Text == fieldButtons[4].Text &&
                        fieldButtons[2].Text == fieldButtons[6].Text &&
                        fieldButtons[0].Text != "")
                {
                    winCombination[0] = 2;
                    winCombination[1] = 4;
                    winCombination[2] = 6;
                    isGameOver = true;
                }
            }
        }

        private void Win()
        {
            for(int i = 0; i < winCombination.Length; i++)
            {
                if (winCombination[i] == -1) break;
                fieldButtons[winCombination[i]].BackColor = Color.LightYellow;
            }
        }



    }
}
