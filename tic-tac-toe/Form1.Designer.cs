namespace tic_tac_toe
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RestartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.field0 = new System.Windows.Forms.Button();
            this.field1 = new System.Windows.Forms.Button();
            this.field2 = new System.Windows.Forms.Button();
            this.field3 = new System.Windows.Forms.Button();
            this.field4 = new System.Windows.Forms.Button();
            this.field5 = new System.Windows.Forms.Button();
            this.field6 = new System.Windows.Forms.Button();
            this.field7 = new System.Windows.Forms.Button();
            this.field8 = new System.Windows.Forms.Button();
            this.PlayerTurn = new System.Windows.Forms.TextBox();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.Player1Score = new System.Windows.Forms.TextBox();
            this.Player2Score = new System.Windows.Forms.TextBox();
            this.StartNewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Lime;
            this.RestartButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RestartButton.Location = new System.Drawing.Point(12, 12);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(145, 82);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ExitButton.Location = new System.Drawing.Point(466, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(145, 82);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // field0
            // 
            this.field0.BackColor = System.Drawing.Color.White;
            this.field0.Location = new System.Drawing.Point(185, 128);
            this.field0.Name = "field0";
            this.field0.Size = new System.Drawing.Size(80, 80);
            this.field0.TabIndex = 2;
            this.field0.UseVisualStyleBackColor = false;
            this.field0.Click += new System.EventHandler(this.field0_Click);
            // 
            // field1
            // 
            this.field1.BackColor = System.Drawing.Color.White;
            this.field1.Location = new System.Drawing.Point(271, 128);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(80, 80);
            this.field1.TabIndex = 3;
            this.field1.UseVisualStyleBackColor = false;
            this.field1.Click += new System.EventHandler(this.field1_Click);
            // 
            // field2
            // 
            this.field2.BackColor = System.Drawing.Color.White;
            this.field2.Location = new System.Drawing.Point(357, 129);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(80, 80);
            this.field2.TabIndex = 4;
            this.field2.UseVisualStyleBackColor = false;
            this.field2.Click += new System.EventHandler(this.field2_Click);
            // 
            // field3
            // 
            this.field3.BackColor = System.Drawing.Color.White;
            this.field3.Location = new System.Drawing.Point(185, 214);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(80, 80);
            this.field3.TabIndex = 5;
            this.field3.UseVisualStyleBackColor = false;
            this.field3.Click += new System.EventHandler(this.field3_Click);
            // 
            // field4
            // 
            this.field4.BackColor = System.Drawing.Color.White;
            this.field4.Location = new System.Drawing.Point(271, 214);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(80, 80);
            this.field4.TabIndex = 6;
            this.field4.UseVisualStyleBackColor = false;
            this.field4.Click += new System.EventHandler(this.field4_Click);
            // 
            // field5
            // 
            this.field5.BackColor = System.Drawing.Color.White;
            this.field5.Location = new System.Drawing.Point(357, 215);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(80, 80);
            this.field5.TabIndex = 7;
            this.field5.UseVisualStyleBackColor = false;
            this.field5.Click += new System.EventHandler(this.field5_Click);
            // 
            // field6
            // 
            this.field6.BackColor = System.Drawing.Color.White;
            this.field6.Location = new System.Drawing.Point(185, 300);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(80, 80);
            this.field6.TabIndex = 8;
            this.field6.UseVisualStyleBackColor = false;
            this.field6.Click += new System.EventHandler(this.field6_Click);
            // 
            // field7
            // 
            this.field7.BackColor = System.Drawing.Color.White;
            this.field7.Location = new System.Drawing.Point(271, 300);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(80, 80);
            this.field7.TabIndex = 9;
            this.field7.UseVisualStyleBackColor = false;
            this.field7.Click += new System.EventHandler(this.field7_Click);
            // 
            // field8
            // 
            this.field8.BackColor = System.Drawing.Color.White;
            this.field8.Location = new System.Drawing.Point(357, 300);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(80, 80);
            this.field8.TabIndex = 10;
            this.field8.UseVisualStyleBackColor = false;
            this.field8.Click += new System.EventHandler(this.field8_Click);
            // 
            // PlayerTurn
            // 
            this.PlayerTurn.Location = new System.Drawing.Point(217, 74);
            this.PlayerTurn.Name = "PlayerTurn";
            this.PlayerTurn.ReadOnly = true;
            this.PlayerTurn.Size = new System.Drawing.Size(190, 20);
            this.PlayerTurn.TabIndex = 11;
            this.PlayerTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(271, 398);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.ReadOnly = true;
            this.ScoreTextBox.Size = new System.Drawing.Size(80, 20);
            this.ScoreTextBox.TabIndex = 12;
            this.ScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player1Score
            // 
            this.Player1Score.Location = new System.Drawing.Point(185, 424);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.ReadOnly = true;
            this.Player1Score.Size = new System.Drawing.Size(117, 20);
            this.Player1Score.TabIndex = 13;
            this.Player1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player2Score
            // 
            this.Player2Score.Location = new System.Drawing.Point(320, 424);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.ReadOnly = true;
            this.Player2Score.Size = new System.Drawing.Size(117, 20);
            this.Player2Score.TabIndex = 14;
            this.Player2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartNewGameButton
            // 
            this.StartNewGameButton.BackColor = System.Drawing.Color.Red;
            this.StartNewGameButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StartNewGameButton.Location = new System.Drawing.Point(12, 129);
            this.StartNewGameButton.Name = "StartNewGameButton";
            this.StartNewGameButton.Size = new System.Drawing.Size(145, 82);
            this.StartNewGameButton.TabIndex = 15;
            this.StartNewGameButton.Text = "Start new game";
            this.StartNewGameButton.UseVisualStyleBackColor = false;
            this.StartNewGameButton.Click += new System.EventHandler(this.StartNewGameButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(623, 473);
            this.Controls.Add(this.StartNewGameButton);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.PlayerTurn);
            this.Controls.Add(this.field8);
            this.Controls.Add(this.field7);
            this.Controls.Add(this.field6);
            this.Controls.Add(this.field5);
            this.Controls.Add(this.field4);
            this.Controls.Add(this.field3);
            this.Controls.Add(this.field2);
            this.Controls.Add(this.field1);
            this.Controls.Add(this.field0);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RestartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(639, 512);
            this.MinimumSize = new System.Drawing.Size(639, 512);
            this.Name = "Form";
            this.Text = "tic-tac-toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button field0;
        private System.Windows.Forms.Button field1;
        private System.Windows.Forms.Button field2;
        private System.Windows.Forms.Button field3;
        private System.Windows.Forms.Button field4;
        private System.Windows.Forms.Button field5;
        private System.Windows.Forms.Button field6;
        private System.Windows.Forms.Button field7;
        private System.Windows.Forms.Button field8;
        private System.Windows.Forms.TextBox PlayerTurn;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.TextBox Player1Score;
        private System.Windows.Forms.TextBox Player2Score;
        private System.Windows.Forms.Button StartNewGameButton;
    }
}

