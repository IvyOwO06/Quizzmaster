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
        bool admin = true;

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
            tabControl.TabPages.Remove(tbpLogin);
            tabControl.TabPages.Add(tbpQuiz);
            if (admin)
            {
                tabControl.TabPages.Add(tbpAdmin);
            }
            ResizeFormToFit(tbpQuiz);
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
    }
}
