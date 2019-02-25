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
                }
            );
            this.player = 1;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {

        }

        private void field0_Click(object sender, EventArgs e)
        {
            controller.FieldClick(0);
        }

        private void field1_Click(object sender, EventArgs e)
        {
            controller.FieldClick(1);
        }

        private void field2_Click(object sender, EventArgs e)
        {
            controller.FieldClick(2);
        }

        private void field3_Click(object sender, EventArgs e)
        {
            controller.FieldClick(3);
        }

        private void field4_Click(object sender, EventArgs e)
        {
            controller.FieldClick(4);
        }

        private void field5_Click(object sender, EventArgs e)
        {
            controller.FieldClick(5);
        }

        private void field6_Click(object sender, EventArgs e)
        {
            controller.FieldClick(6);
        }

        private void field7_Click(object sender, EventArgs e)
        {
            controller.FieldClick(7);
        }

        private void field8_Click(object sender, EventArgs e)
        {
            controller.FieldClick(8);
        }

    }
}
