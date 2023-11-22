namespace TicTacToe
{
    partial class TicTacToe
    {
        // Create Game
        public Game game;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // playerXScore
            // 
            playerXScore.AutoSize = true;
            playerXScore.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerXScore.ForeColor = Color.Blue;
            playerXScore.Location = new Point(103, 38);
            playerXScore.Name = "playerXScore";
            playerXScore.Player = 'X';
            playerXScore.Size = new Size(28, 35);
            playerXScore.TabIndex = 11;
            playerXScore.Text = "0";
            // 
            // playerOScore
            // 
            playerOScore.AutoSize = true;
            playerOScore.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            playerOScore.ForeColor = Color.Red;
            playerOScore.Location = new Point(307, 38);
            playerOScore.Name = "playerOScore";
            playerOScore.Player = 'O';
            playerOScore.Size = new Size(28, 35);
            playerOScore.TabIndex = 12;
            playerOScore.Text = "0";
            // 
            // place1
            // 
            place1.BackColor = SystemColors.ControlDarkDark;
            place1.FlatAppearance.BorderColor = Color.Black;
            place1.FlatAppearance.BorderSize = 3;
            place1.FlatStyle = FlatStyle.Popup;
            place1.Location = new Point(60, 100);
            place1.Name = "place1";
            place1.PlayerSymbol = ' ';
            place1.Size = new Size(90, 90);
            place1.TabIndex = 0;
            place1.UseVisualStyleBackColor = false;
            // 
            // place2
            // 
            place2.BackColor = SystemColors.ControlDarkDark;
            place2.FlatAppearance.BorderColor = Color.Black;
            place2.FlatAppearance.BorderSize = 3;
            place2.FlatStyle = FlatStyle.Popup;
            place2.Location = new Point(170, 100);
            place2.Name = "place2";
            place2.PlayerSymbol = ' ';
            place2.Size = new Size(90, 90);
            place2.TabIndex = 1;
            place2.UseVisualStyleBackColor = false;
            // 
            // place3
            // 
            place3.BackColor = SystemColors.ControlDarkDark;
            place3.FlatAppearance.BorderColor = Color.Black;
            place3.FlatAppearance.BorderSize = 3;
            place3.FlatStyle = FlatStyle.Popup;
            place3.Location = new Point(280, 100);
            place3.Name = "place3";
            place3.PlayerSymbol = ' ';
            place3.Size = new Size(90, 90);
            place3.TabIndex = 2;
            place3.UseVisualStyleBackColor = false;
            // 
            // place4
            // 
            place4.BackColor = SystemColors.ControlDarkDark;
            place4.FlatAppearance.BorderColor = Color.Black;
            place4.FlatAppearance.BorderSize = 3;
            place4.FlatStyle = FlatStyle.Popup;
            place4.Location = new Point(60, 210);
            place4.Name = "place4";
            place4.PlayerSymbol = ' ';
            place4.Size = new Size(90, 90);
            place4.TabIndex = 3;
            place4.UseVisualStyleBackColor = false;
            // 
            // place5
            // 
            place5.BackColor = SystemColors.ControlDarkDark;
            place5.FlatAppearance.BorderColor = Color.Black;
            place5.FlatAppearance.BorderSize = 3;
            place5.FlatStyle = FlatStyle.Popup;
            place5.Location = new Point(170, 210);
            place5.Name = "place5";
            place5.PlayerSymbol = ' ';
            place5.Size = new Size(90, 90);
            place5.TabIndex = 4;
            place5.UseVisualStyleBackColor = false;
            // 
            // place6
            // 
            place6.BackColor = SystemColors.ControlDarkDark;
            place6.FlatAppearance.BorderColor = Color.Black;
            place6.FlatAppearance.BorderSize = 3;
            place6.FlatStyle = FlatStyle.Popup;
            place6.Location = new Point(280, 210);
            place6.Name = "place6";
            place6.PlayerSymbol = ' ';
            place6.Size = new Size(90, 90);
            place6.TabIndex = 5;
            place6.UseVisualStyleBackColor = false;
            // 
            // place7
            // 
            place7.BackColor = SystemColors.ControlDarkDark;
            place7.FlatAppearance.BorderColor = Color.Black;
            place7.FlatAppearance.BorderSize = 3;
            place7.FlatStyle = FlatStyle.Popup;
            place7.Location = new Point(60, 320);
            place7.Name = "place7";
            place7.PlayerSymbol = ' ';
            place7.Size = new Size(90, 90);
            place7.TabIndex = 6;
            place7.UseVisualStyleBackColor = false;
            // 
            // place8
            // 
            place8.BackColor = SystemColors.ControlDarkDark;
            place8.FlatAppearance.BorderColor = Color.Black;
            place8.FlatAppearance.BorderSize = 3;
            place8.FlatStyle = FlatStyle.Popup;
            place8.Location = new Point(170, 320);
            place8.Name = "place8";
            place8.PlayerSymbol = ' ';
            place8.Size = new Size(90, 90);
            place8.TabIndex = 7;
            place8.UseVisualStyleBackColor = false;
            // 
            // place9
            // 
            place9.BackColor = SystemColors.ControlDarkDark;
            place9.FlatAppearance.BorderColor = Color.Black;
            place9.FlatAppearance.BorderSize = 3;
            place9.FlatStyle = FlatStyle.Popup;
            place9.Location = new Point(280, 320);
            place9.Name = "place9";
            place9.PlayerSymbol = ' ';
            place9.Size = new Size(90, 90);
            place9.TabIndex = 8;
            place9.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 9;
            label1.Text = "Player X Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(263, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 10;
            label2.Text = "Player O Score";
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 453);
            Controls.Add(playerOScore);
            Controls.Add(playerXScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(place9);
            Controls.Add(place8);
            Controls.Add(place7);
            Controls.Add(place6);
            Controls.Add(place5);
            Controls.Add(place4);
            Controls.Add(place3);
            Controls.Add(place2);
            Controls.Add(place1);
            MaximizeBox = false;
            Name = "TicTacToe";
            Text = "TicTacToe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Place place1;
        private Place place2;
        private Place place3;
        private Place place6;
        private Place place5;
        private Place place4;
        private Place place9;
        private Place place8;
        private Place place7;
        private Label label1;
        private Label label2;
        private Score playerXScore;
        private Score playerOScore;
    }
}