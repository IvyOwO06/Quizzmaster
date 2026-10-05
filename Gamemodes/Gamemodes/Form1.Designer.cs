namespace Gamemodes
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnTimeLimitMode = new System.Windows.Forms.Button();
            this.btnRandomMode = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(17, 24);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(116, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Press start";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(179, 142);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(39, 42);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "0";
            // 
            // btnTimeLimitMode
            // 
            this.btnTimeLimitMode.Location = new System.Drawing.Point(12, 172);
            this.btnTimeLimitMode.Name = "btnTimeLimitMode";
            this.btnTimeLimitMode.Size = new System.Drawing.Size(90, 23);
            this.btnTimeLimitMode.TabIndex = 2;
            this.btnTimeLimitMode.Text = "Time Limit";
            this.btnTimeLimitMode.UseVisualStyleBackColor = true;
            this.btnTimeLimitMode.Click += new System.EventHandler(this.btnTimeLimitMode_Click);
            // 
            // btnRandomMode
            // 
            this.btnRandomMode.Location = new System.Drawing.Point(293, 172);
            this.btnRandomMode.Name = "btnRandomMode";
            this.btnRandomMode.Size = new System.Drawing.Size(121, 23);
            this.btnRandomMode.TabIndex = 3;
            this.btnRandomMode.Text = "Random Answer";
            this.btnRandomMode.UseVisualStyleBackColor = true;
            this.btnRandomMode.Click += new System.EventHandler(this.btnRandomMode_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1000;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(12, 201);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(198, 237);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(216, 201);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(198, 237);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnRandomMode);
            this.Controls.Add(this.btnTimeLimitMode);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnTimeLimitMode;
        private System.Windows.Forms.Button btnRandomMode;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}

