namespace eindproject
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbpLogin = new System.Windows.Forms.TabPage();
            this.tbxLoginPassword = new System.Windows.Forms.TextBox();
            this.tbxLoginUsername = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnToRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbpRegister = new System.Windows.Forms.TabPage();
            this.btnToLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbxRegisterCPassword = new System.Windows.Forms.TextBox();
            this.tbxRegisterPassword = new System.Windows.Forms.TextBox();
            this.tbxRegisterUsername = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbpQuiz = new System.Windows.Forms.TabPage();
            this.btnSkip = new System.Windows.Forms.Button();
            this.lbxHighscore = new System.Windows.Forms.ListBox();
            this.cbxShowHighscore = new System.Windows.Forms.CheckBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.tbpAdmin = new System.Windows.Forms.TabPage();
            this.tbxCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdminAddAcoount = new System.Windows.Forms.Button();
            this.tbxAdminCPassword = new System.Windows.Forms.TextBox();
            this.tbxAdminPassword = new System.Windows.Forms.TextBox();
            this.tbxAdminUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.tbxWrongAnswer3 = new System.Windows.Forms.TextBox();
            this.tbxWrongAnswer2 = new System.Windows.Forms.TextBox();
            this.tbxWrongAnswer1 = new System.Windows.Forms.TextBox();
            this.tbxRightAnswer = new System.Windows.Forms.TextBox();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrQuiz = new System.Windows.Forms.Timer(this.components);
            this.tmrQuestion = new System.Windows.Forms.Timer(this.components);
            this.cbxIsAdmin = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tbpLogin.SuspendLayout();
            this.tbpRegister.SuspendLayout();
            this.tbpQuiz.SuspendLayout();
            this.tbpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbpLogin);
            this.tabControl.Controls.Add(this.tbpRegister);
            this.tabControl.Controls.Add(this.tbpQuiz);
            this.tabControl.Controls.Add(this.tbpAdmin);
            this.tabControl.Location = new System.Drawing.Point(2, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 568);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tbpLogin
            // 
            this.tbpLogin.Controls.Add(this.tbxLoginPassword);
            this.tbpLogin.Controls.Add(this.tbxLoginUsername);
            this.tbpLogin.Controls.Add(this.label13);
            this.tbpLogin.Controls.Add(this.label12);
            this.tbpLogin.Controls.Add(this.label11);
            this.tbpLogin.Controls.Add(this.btnToRegister);
            this.tbpLogin.Controls.Add(this.btnLogin);
            this.tbpLogin.Location = new System.Drawing.Point(4, 25);
            this.tbpLogin.Name = "tbpLogin";
            this.tbpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLogin.Size = new System.Drawing.Size(1092, 539);
            this.tbpLogin.TabIndex = 0;
            this.tbpLogin.Text = "Login";
            this.tbpLogin.UseVisualStyleBackColor = true;
            // 
            // tbxLoginPassword
            // 
            this.tbxLoginPassword.Location = new System.Drawing.Point(6, 125);
            this.tbxLoginPassword.Name = "tbxLoginPassword";
            this.tbxLoginPassword.Size = new System.Drawing.Size(205, 22);
            this.tbxLoginPassword.TabIndex = 6;
            this.tbxLoginPassword.UseSystemPasswordChar = true;
            // 
            // tbxLoginUsername
            // 
            this.tbxLoginUsername.Location = new System.Drawing.Point(6, 70);
            this.tbxLoginUsername.Name = "tbxLoginUsername";
            this.tbxLoginUsername.Size = new System.Drawing.Size(205, 22);
            this.tbxLoginUsername.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Username";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "LOGIN";
            // 
            // btnToRegister
            // 
            this.btnToRegister.Location = new System.Drawing.Point(6, 162);
            this.btnToRegister.Name = "btnToRegister";
            this.btnToRegister.Size = new System.Drawing.Size(124, 32);
            this.btnToRegister.TabIndex = 1;
            this.btnToRegister.Text = "Register Instead";
            this.btnToRegister.UseVisualStyleBackColor = true;
            this.btnToRegister.Click += new System.EventHandler(this.btnToRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(136, 162);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 32);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbpRegister
            // 
            this.tbpRegister.Controls.Add(this.btnToLogin);
            this.tbpRegister.Controls.Add(this.btnRegister);
            this.tbpRegister.Controls.Add(this.tbxRegisterCPassword);
            this.tbpRegister.Controls.Add(this.tbxRegisterPassword);
            this.tbpRegister.Controls.Add(this.tbxRegisterUsername);
            this.tbpRegister.Controls.Add(this.label17);
            this.tbpRegister.Controls.Add(this.label16);
            this.tbpRegister.Controls.Add(this.label15);
            this.tbpRegister.Controls.Add(this.label14);
            this.tbpRegister.Location = new System.Drawing.Point(4, 25);
            this.tbpRegister.Name = "tbpRegister";
            this.tbpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegister.Size = new System.Drawing.Size(1092, 539);
            this.tbpRegister.TabIndex = 1;
            this.tbpRegister.Text = "Register";
            this.tbpRegister.UseVisualStyleBackColor = true;
            // 
            // btnToLogin
            // 
            this.btnToLogin.Location = new System.Drawing.Point(9, 237);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(170, 29);
            this.btnToLogin.TabIndex = 8;
            this.btnToLogin.Text = "Back To Login";
            this.btnToLogin.UseVisualStyleBackColor = true;
            this.btnToLogin.Click += new System.EventHandler(this.btnToLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(9, 202);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(170, 29);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbxRegisterCPassword
            // 
            this.tbxRegisterCPassword.Location = new System.Drawing.Point(9, 173);
            this.tbxRegisterCPassword.Name = "tbxRegisterCPassword";
            this.tbxRegisterCPassword.Size = new System.Drawing.Size(170, 22);
            this.tbxRegisterCPassword.TabIndex = 6;
            this.tbxRegisterCPassword.UseSystemPasswordChar = true;
            // 
            // tbxRegisterPassword
            // 
            this.tbxRegisterPassword.Location = new System.Drawing.Point(9, 120);
            this.tbxRegisterPassword.Name = "tbxRegisterPassword";
            this.tbxRegisterPassword.Size = new System.Drawing.Size(170, 22);
            this.tbxRegisterPassword.TabIndex = 5;
            this.tbxRegisterPassword.UseSystemPasswordChar = true;
            // 
            // tbxRegisterUsername
            // 
            this.tbxRegisterUsername.Location = new System.Drawing.Point(9, 66);
            this.tbxRegisterUsername.Name = "tbxRegisterUsername";
            this.tbxRegisterUsername.Size = new System.Drawing.Size(170, 22);
            this.tbxRegisterUsername.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Confirm Password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Create Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Username";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-1, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "REGISTER";
            // 
            // tbpQuiz
            // 
            this.tbpQuiz.Controls.Add(this.btnSkip);
            this.tbpQuiz.Controls.Add(this.lbxHighscore);
            this.tbpQuiz.Controls.Add(this.cbxShowHighscore);
            this.tbpQuiz.Controls.Add(this.lblQuestion);
            this.tbpQuiz.Controls.Add(this.label19);
            this.tbpQuiz.Controls.Add(this.label20);
            this.tbpQuiz.Controls.Add(this.lblTimer);
            this.tbpQuiz.Controls.Add(this.label18);
            this.tbpQuiz.Controls.Add(this.btnAnswer4);
            this.tbpQuiz.Controls.Add(this.btnAnswer3);
            this.tbpQuiz.Controls.Add(this.btnAnswer2);
            this.tbpQuiz.Controls.Add(this.btnAnswer1);
            this.tbpQuiz.Location = new System.Drawing.Point(4, 25);
            this.tbpQuiz.Name = "tbpQuiz";
            this.tbpQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tbpQuiz.Size = new System.Drawing.Size(1092, 539);
            this.tbpQuiz.TabIndex = 2;
            this.tbpQuiz.Text = "Quiz";
            this.tbpQuiz.UseVisualStyleBackColor = true;
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(10, 102);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 11;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            // 
            // lbxHighscore
            // 
            this.lbxHighscore.FormattingEnabled = true;
            this.lbxHighscore.ItemHeight = 16;
            this.lbxHighscore.Location = new System.Drawing.Point(789, 7);
            this.lbxHighscore.Name = "lbxHighscore";
            this.lbxHighscore.Size = new System.Drawing.Size(293, 404);
            this.lbxHighscore.TabIndex = 10;
            this.lbxHighscore.Visible = false;
            // 
            // cbxShowHighscore
            // 
            this.cbxShowHighscore.AutoSize = true;
            this.cbxShowHighscore.Location = new System.Drawing.Point(658, 105);
            this.cbxShowHighscore.Name = "cbxShowHighscore";
            this.cbxShowHighscore.Size = new System.Drawing.Size(124, 20);
            this.cbxShowHighscore.TabIndex = 9;
            this.cbxShowHighscore.Text = "Show Highscore";
            this.cbxShowHighscore.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(28, 46);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(145, 20);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "Choose a Category";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(654, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 20);
            this.label19.TabIndex = 7;
            this.label19.Text = "Score:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(725, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "0000";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(59, 15);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(27, 20);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "60";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 20);
            this.label18.TabIndex = 4;
            this.label18.Text = "Time:";
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Enabled = false;
            this.btnAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.Location = new System.Drawing.Point(397, 272);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(385, 135);
            this.btnAnswer4.TabIndex = 3;
            this.btnAnswer4.Text = "button5";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.Location = new System.Drawing.Point(6, 272);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(385, 135);
            this.btnAnswer3.TabIndex = 2;
            this.btnAnswer3.Text = "General";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.Location = new System.Drawing.Point(397, 131);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(385, 135);
            this.btnAnswer2.TabIndex = 1;
            this.btnAnswer2.Text = "Undertale";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.Location = new System.Drawing.Point(6, 131);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(385, 135);
            this.btnAnswer1.TabIndex = 0;
            this.btnAnswer1.Text = "Deltarune";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            // 
            // tbpAdmin
            // 
            this.tbpAdmin.Controls.Add(this.cbxIsAdmin);
            this.tbpAdmin.Controls.Add(this.tbxCategory);
            this.tbpAdmin.Controls.Add(this.label10);
            this.tbpAdmin.Controls.Add(this.btnAdminAddAcoount);
            this.tbpAdmin.Controls.Add(this.tbxAdminCPassword);
            this.tbpAdmin.Controls.Add(this.tbxAdminPassword);
            this.tbpAdmin.Controls.Add(this.tbxAdminUsername);
            this.tbpAdmin.Controls.Add(this.label7);
            this.tbpAdmin.Controls.Add(this.label8);
            this.tbpAdmin.Controls.Add(this.label9);
            this.tbpAdmin.Controls.Add(this.label6);
            this.tbpAdmin.Controls.Add(this.btnRemoveAccount);
            this.tbpAdmin.Controls.Add(this.dgvAccounts);
            this.tbpAdmin.Controls.Add(this.btnAddQuestion);
            this.tbpAdmin.Controls.Add(this.btnEditQuestion);
            this.tbpAdmin.Controls.Add(this.btnRemoveQuestion);
            this.tbpAdmin.Controls.Add(this.dgvQuestions);
            this.tbpAdmin.Controls.Add(this.tbxWrongAnswer3);
            this.tbpAdmin.Controls.Add(this.tbxWrongAnswer2);
            this.tbpAdmin.Controls.Add(this.tbxWrongAnswer1);
            this.tbpAdmin.Controls.Add(this.tbxRightAnswer);
            this.tbpAdmin.Controls.Add(this.tbxQuestion);
            this.tbpAdmin.Controls.Add(this.label5);
            this.tbpAdmin.Controls.Add(this.label3);
            this.tbpAdmin.Controls.Add(this.label4);
            this.tbpAdmin.Controls.Add(this.label2);
            this.tbpAdmin.Controls.Add(this.label1);
            this.tbpAdmin.Location = new System.Drawing.Point(4, 25);
            this.tbpAdmin.Name = "tbpAdmin";
            this.tbpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdmin.Size = new System.Drawing.Size(1092, 539);
            this.tbpAdmin.TabIndex = 3;
            this.tbpAdmin.Text = "Admin Panel";
            this.tbpAdmin.UseVisualStyleBackColor = true;
            // 
            // tbxCategory
            // 
            this.tbxCategory.Location = new System.Drawing.Point(108, 34);
            this.tbxCategory.Name = "tbxCategory";
            this.tbxCategory.Size = new System.Drawing.Size(100, 22);
            this.tbxCategory.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Category:";
            // 
            // btnAdminAddAcoount
            // 
            this.btnAdminAddAcoount.Location = new System.Drawing.Point(409, 140);
            this.btnAdminAddAcoount.Name = "btnAdminAddAcoount";
            this.btnAdminAddAcoount.Size = new System.Drawing.Size(100, 23);
            this.btnAdminAddAcoount.TabIndex = 23;
            this.btnAdminAddAcoount.Text = "Add Account";
            this.btnAdminAddAcoount.UseVisualStyleBackColor = true;
            // 
            // tbxAdminCPassword
            // 
            this.tbxAdminCPassword.Location = new System.Drawing.Point(409, 87);
            this.tbxAdminCPassword.Name = "tbxAdminCPassword";
            this.tbxAdminCPassword.Size = new System.Drawing.Size(100, 22);
            this.tbxAdminCPassword.TabIndex = 22;
            // 
            // tbxAdminPassword
            // 
            this.tbxAdminPassword.Location = new System.Drawing.Point(409, 59);
            this.tbxAdminPassword.Name = "tbxAdminPassword";
            this.tbxAdminPassword.Size = new System.Drawing.Size(100, 22);
            this.tbxAdminPassword.TabIndex = 21;
            // 
            // tbxAdminUsername
            // 
            this.tbxAdminUsername.Location = new System.Drawing.Point(409, 31);
            this.tbxAdminUsername.Name = "tbxAdminUsername";
            this.tbxAdminUsername.Size = new System.Drawing.Size(100, 22);
            this.tbxAdminUsername.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Confirm Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Accounts";
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Location = new System.Drawing.Point(434, 507);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAccount.TabIndex = 15;
            this.btnRemoveAccount.Text = "Remove";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(515, 3);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.Size = new System.Drawing.Size(271, 527);
            this.dgvAccounts.TabIndex = 14;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(214, 147);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuestion.TabIndex = 13;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(295, 507);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnEditQuestion.TabIndex = 12;
            this.btnEditQuestion.Text = "Edit";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Location = new System.Drawing.Point(295, 478);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveQuestion.TabIndex = 11;
            this.btnRemoveQuestion.Text = "Remove";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(6, 176);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowTemplate.Height = 24;
            this.dgvQuestions.Size = new System.Drawing.Size(283, 354);
            this.dgvQuestions.TabIndex = 10;
            // 
            // tbxWrongAnswer3
            // 
            this.tbxWrongAnswer3.Location = new System.Drawing.Point(108, 148);
            this.tbxWrongAnswer3.Name = "tbxWrongAnswer3";
            this.tbxWrongAnswer3.Size = new System.Drawing.Size(100, 22);
            this.tbxWrongAnswer3.TabIndex = 9;
            // 
            // tbxWrongAnswer2
            // 
            this.tbxWrongAnswer2.Location = new System.Drawing.Point(108, 118);
            this.tbxWrongAnswer2.Name = "tbxWrongAnswer2";
            this.tbxWrongAnswer2.Size = new System.Drawing.Size(100, 22);
            this.tbxWrongAnswer2.TabIndex = 8;
            // 
            // tbxWrongAnswer1
            // 
            this.tbxWrongAnswer1.Location = new System.Drawing.Point(108, 90);
            this.tbxWrongAnswer1.Name = "tbxWrongAnswer1";
            this.tbxWrongAnswer1.Size = new System.Drawing.Size(100, 22);
            this.tbxWrongAnswer1.TabIndex = 7;
            // 
            // tbxRightAnswer
            // 
            this.tbxRightAnswer.Location = new System.Drawing.Point(108, 62);
            this.tbxRightAnswer.Name = "tbxRightAnswer";
            this.tbxRightAnswer.Size = new System.Drawing.Size(100, 22);
            this.tbxRightAnswer.TabIndex = 6;
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(108, 6);
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(100, 22);
            this.tbxQuestion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wrong Answer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wrong Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wrong Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right Answer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // tmrQuiz
            // 
            this.tmrQuiz.Interval = 1000;
            // 
            // tmrQuestion
            // 
            this.tmrQuestion.Interval = 1000;
            // 
            // cbxIsAdmin
            // 
            this.cbxIsAdmin.AutoSize = true;
            this.cbxIsAdmin.Location = new System.Drawing.Point(409, 114);
            this.cbxIsAdmin.Name = "cbxIsAdmin";
            this.cbxIsAdmin.Size = new System.Drawing.Size(71, 20);
            this.cbxIsAdmin.TabIndex = 26;
            this.cbxIsAdmin.Text = "Admin?";
            this.cbxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 579);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tbpLogin.ResumeLayout(false);
            this.tbpLogin.PerformLayout();
            this.tbpRegister.ResumeLayout(false);
            this.tbpRegister.PerformLayout();
            this.tbpQuiz.ResumeLayout(false);
            this.tbpQuiz.PerformLayout();
            this.tbpAdmin.ResumeLayout(false);
            this.tbpAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbpLogin;
        private System.Windows.Forms.TabPage tbpAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.TextBox tbxWrongAnswer3;
        private System.Windows.Forms.TextBox tbxWrongAnswer2;
        private System.Windows.Forms.TextBox tbxWrongAnswer1;
        private System.Windows.Forms.TextBox tbxRightAnswer;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdminAddAcoount;
        private System.Windows.Forms.TextBox tbxAdminCPassword;
        private System.Windows.Forms.TextBox tbxAdminPassword;
        private System.Windows.Forms.TextBox tbxAdminUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.TextBox tbxCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tbpQuiz;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabPage tbpRegister;
        private System.Windows.Forms.Button btnToRegister;
        private System.Windows.Forms.TextBox tbxLoginPassword;
        private System.Windows.Forms.TextBox tbxLoginUsername;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.TextBox tbxRegisterPassword;
        private System.Windows.Forms.TextBox tbxRegisterUsername;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbxRegisterCPassword;
        private System.Windows.Forms.Button btnToLogin;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Timer tmrQuiz;
        private System.Windows.Forms.Timer tmrQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cbxShowHighscore;
        private System.Windows.Forms.ListBox lbxHighscore;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.CheckBox cbxIsAdmin;
    }
}

