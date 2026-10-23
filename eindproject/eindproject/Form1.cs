using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eindproject
{
    public partial class Form1 : Form
    {
        Auth auth = null;

        string username = "";
        string password = "";
        string cpassword = "";

        public Form1()
        {
            InitializeComponent();

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tbpAdmin);
            tabControl.TabPages.Remove(tbpQuiz);
            tabControl.TabPages.Remove(tbpRegister);
            ResizeFormToFit(tbpLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbxLoginUsername.Text;
            password = tbxLoginPassword.Text;

            auth = new Auth();

            bool success = auth.Login(username, password);

            if (success)
            {
                User loggedInUser = auth.GetLoggedInUser();

                username = loggedInUser.GetUsername();

                bool isAdmin = loggedInUser.GetIsAdmin();

                MessageBox.Show("Welcome " + username + "!");

                tabControl.TabPages.Remove(tbpLogin);
                tabControl.TabPages.Add(tbpQuiz);
                ResizeFormToFit(tbpQuiz);

                if (isAdmin)
                {
                    tabControl.TabPages.Add(tbpAdmin);
                }
            }
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tbpLogin);
            tabControl.TabPages.Add(tbpRegister);
            ResizeFormToFit(tbpRegister);
        }

        private void ResizeFormToFit(TabPage page)
        {
            if (page == null)
                return;

            int right = 0;
            int bottom = 0;

            foreach (Control control in page.Controls)
            {
                right = Math.Max(right, control.Right);
                bottom = Math.Max(bottom, control.Bottom);
            }

            int padding = 20;

            // Resize the TabControl to fit the page contents
            tabControl.Width = right + padding;
            tabControl.Height = bottom + padding + 20;

            // Resize the form to fit the TabControl
            this.ClientSize = new Size(
                tabControl.Right,
                tabControl.Bottom
            );
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResizeFormToFit(tabControl.SelectedTab);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            username = tbxRegisterUsername.Text;
            password = tbxRegisterPassword.Text;
            cpassword = tbxRegisterCPassword.Text;

            auth = new Auth();
            bool success = auth.Register(username, password, cpassword);

            if (success)
            {
                tabControl.TabPages.Remove(tbpRegister);
                tabControl.TabPages.Add(tbpLogin);
                ResizeFormToFit(tbpLogin);
            }
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tbpRegister);
            tabControl.TabPages.Add(tbpLogin);
            ResizeFormToFit(tbpLogin);
        }
    }
}
