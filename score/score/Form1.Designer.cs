namespace score
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbxHighscore = new System.Windows.Forms.ListBox();
            this.lblCountdownText = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPlayername = new System.Windows.Forms.TextBox();
            this.cbxHighscore = new System.Windows.Forms.CheckBox();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.pnlOne = new System.Windows.Forms.Panel();
            this.pnlTwo = new System.Windows.Forms.Panel();
            this.pnlThree = new System.Windows.Forms.Panel();
            this.pnlFour = new System.Windows.Forms.Panel();
            this.pnlFive = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbxHighscore
            // 
            this.lbxHighscore.FormattingEnabled = true;
            this.lbxHighscore.ItemHeight = 16;
            this.lbxHighscore.Location = new System.Drawing.Point(725, 16);
            this.lbxHighscore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxHighscore.Name = "lbxHighscore";
            this.lbxHighscore.Size = new System.Drawing.Size(504, 372);
            this.lbxHighscore.TabIndex = 5;
            // 
            // lblCountdownText
            // 
            this.lblCountdownText.AutoSize = true;
            this.lblCountdownText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdownText.Location = new System.Drawing.Point(11, 209);
            this.lblCountdownText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountdownText.Name = "lblCountdownText";
            this.lblCountdownText.Size = new System.Drawing.Size(338, 29);
            this.lblCountdownText.TabIndex = 6;
            this.lblCountdownText.Text = "Fill in your player name to start";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(17, 350);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(133, 39);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(197, 350);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(133, 39);
            this.btnStartGame.TabIndex = 8;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Playername:";
            // 
            // tbxPlayername
            // 
            this.tbxPlayername.Location = new System.Drawing.Point(411, 364);
            this.tbxPlayername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPlayername.Name = "tbxPlayername";
            this.tbxPlayername.Size = new System.Drawing.Size(132, 22);
            this.tbxPlayername.TabIndex = 10;
            this.tbxPlayername.TextChanged += new System.EventHandler(this.tbxPlayername_TextChanged);
            // 
            // cbxHighscore
            // 
            this.cbxHighscore.AutoSize = true;
            this.cbxHighscore.Location = new System.Drawing.Point(611, 368);
            this.cbxHighscore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxHighscore.Name = "cbxHighscore";
            this.cbxHighscore.Size = new System.Drawing.Size(88, 20);
            this.cbxHighscore.TabIndex = 11;
            this.cbxHighscore.Text = "Highscore";
            this.cbxHighscore.UseVisualStyleBackColor = true;
            this.cbxHighscore.CheckedChanged += new System.EventHandler(this.cbxHighscore_CheckedChanged);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // pnlOne
            // 
            this.pnlOne.Location = new System.Drawing.Point(16, 15);
            this.pnlOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOne.Name = "pnlOne";
            this.pnlOne.Size = new System.Drawing.Size(133, 123);
            this.pnlOne.TabIndex = 12;
            // 
            // pnlTwo
            // 
            this.pnlTwo.Location = new System.Drawing.Point(157, 15);
            this.pnlTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTwo.Name = "pnlTwo";
            this.pnlTwo.Size = new System.Drawing.Size(133, 123);
            this.pnlTwo.TabIndex = 13;
            // 
            // pnlThree
            // 
            this.pnlThree.Location = new System.Drawing.Point(299, 16);
            this.pnlThree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlThree.Name = "pnlThree";
            this.pnlThree.Size = new System.Drawing.Size(133, 123);
            this.pnlThree.TabIndex = 14;
            // 
            // pnlFour
            // 
            this.pnlFour.Location = new System.Drawing.Point(440, 15);
            this.pnlFour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFour.Name = "pnlFour";
            this.pnlFour.Size = new System.Drawing.Size(133, 123);
            this.pnlFour.TabIndex = 14;
            // 
            // pnlFive
            // 
            this.pnlFive.Location = new System.Drawing.Point(584, 15);
            this.pnlFive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFive.Name = "pnlFive";
            this.pnlFive.Size = new System.Drawing.Size(133, 123);
            this.pnlFive.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 401);
            this.Controls.Add(this.pnlFive);
            this.Controls.Add(this.pnlFour);
            this.Controls.Add(this.pnlThree);
            this.Controls.Add(this.pnlTwo);
            this.Controls.Add(this.pnlOne);
            this.Controls.Add(this.cbxHighscore);
            this.Controls.Add(this.tbxPlayername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblCountdownText);
            this.Controls.Add(this.lbxHighscore);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxHighscore;
        private System.Windows.Forms.Label lblCountdownText;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPlayername;
        private System.Windows.Forms.CheckBox cbxHighscore;
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Panel pnlOne;
        private System.Windows.Forms.Panel pnlTwo;
        private System.Windows.Forms.Panel pnlThree;
        private System.Windows.Forms.Panel pnlFour;
        private System.Windows.Forms.Panel pnlFive;
    }
}

