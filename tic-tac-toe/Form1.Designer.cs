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
            this.SuspendLayout();
            // 
            // RestartButton
            // 
            this.RestartButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RestartButton.Location = new System.Drawing.Point(12, 19);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(145, 82);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ExitButton.Location = new System.Drawing.Point(466, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(145, 89);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // field0
            // 
            this.field0.Location = new System.Drawing.Point(185, 106);
            this.field0.Name = "field0";
            this.field0.Size = new System.Drawing.Size(80, 80);
            this.field0.TabIndex = 2;
            this.field0.UseVisualStyleBackColor = true;
            this.field0.Click += new System.EventHandler(this.field0_Click);
            // 
            // field1
            // 
            this.field1.Location = new System.Drawing.Point(271, 106);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(80, 80);
            this.field1.TabIndex = 3;
            this.field1.UseVisualStyleBackColor = true;
            this.field1.Click += new System.EventHandler(this.field1_Click);
            // 
            // field2
            // 
            this.field2.Location = new System.Drawing.Point(357, 107);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(80, 80);
            this.field2.TabIndex = 4;
            this.field2.UseVisualStyleBackColor = true;
            this.field2.Click += new System.EventHandler(this.field2_Click);
            // 
            // field3
            // 
            this.field3.Location = new System.Drawing.Point(185, 192);
            this.field3.Name = "field3";
            this.field3.Size = new System.Drawing.Size(80, 80);
            this.field3.TabIndex = 5;
            this.field3.UseVisualStyleBackColor = true;
            this.field3.Click += new System.EventHandler(this.field3_Click);
            // 
            // field4
            // 
            this.field4.Location = new System.Drawing.Point(271, 192);
            this.field4.Name = "field4";
            this.field4.Size = new System.Drawing.Size(80, 80);
            this.field4.TabIndex = 6;
            this.field4.UseVisualStyleBackColor = true;
            this.field4.Click += new System.EventHandler(this.field4_Click);
            // 
            // field5
            // 
            this.field5.Location = new System.Drawing.Point(357, 193);
            this.field5.Name = "field5";
            this.field5.Size = new System.Drawing.Size(80, 80);
            this.field5.TabIndex = 7;
            this.field5.UseVisualStyleBackColor = true;
            this.field5.Click += new System.EventHandler(this.field5_Click);
            // 
            // field6
            // 
            this.field6.Location = new System.Drawing.Point(185, 278);
            this.field6.Name = "field6";
            this.field6.Size = new System.Drawing.Size(80, 80);
            this.field6.TabIndex = 8;
            this.field6.UseVisualStyleBackColor = true;
            this.field6.Click += new System.EventHandler(this.field6_Click);
            // 
            // field7
            // 
            this.field7.Location = new System.Drawing.Point(271, 278);
            this.field7.Name = "field7";
            this.field7.Size = new System.Drawing.Size(80, 80);
            this.field7.TabIndex = 9;
            this.field7.UseVisualStyleBackColor = true;
            this.field7.Click += new System.EventHandler(this.field7_Click);
            // 
            // field8
            // 
            this.field8.Location = new System.Drawing.Point(357, 278);
            this.field8.Name = "field8";
            this.field8.Size = new System.Drawing.Size(80, 80);
            this.field8.TabIndex = 10;
            this.field8.UseVisualStyleBackColor = true;
            this.field8.Click += new System.EventHandler(this.field8_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 473);
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
    }
}

