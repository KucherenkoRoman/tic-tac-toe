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
    public partial class Form : System.Windows.Forms.Form
    {

        private int player;  //1 => first player, 2 => second
        private GameController controller;

        public Form()
        {
            InitializeComponent();
            this.controller = new GameController(
                new Button[]
                {
                    field0, field1, field2,
                    field3, field4, field5,
                    field6, field7, field8
                },
                PlayerTurn
            );
            this.player = 1;
            ScoreTextBox.Text = "Score:";
            Player1Score.BackColor = Color.Green;
            Player2Score.BackColor = Color.Red;
            Player1Score.Text = "Player 1 score: 0";
            Player2Score.Text = "Player 2 score: 0";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            controller.Restart();
        }
        
        private void field0_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(0);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void field1_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(1);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void field2_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(2);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void field3_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(3);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void field4_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(4);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void field5_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(5);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void field6_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(6);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void field7_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(7);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void field8_Click(object sender, EventArgs e)
        {
            controller.ClickEvent(8);
            controller.ShowScore(Player1Score, Player2Score);
        }

        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            controller.StartNewGame();
            controller.ShowScore(Player1Score, Player2Score);
        }

    }
}
