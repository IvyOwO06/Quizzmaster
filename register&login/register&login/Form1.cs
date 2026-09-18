using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace register_login
{
    public partial class Form1 : Form
    {
        string item = "";
        string connectionString = "Server=localhost;Port=3306;Database=c#test;Uid=root;Pwd=;";
        DataTable dataTable = null;
        int row = 0;
        string addName = "";
        int newItemcount = 0;
        string deleteItemname;
        string selectedItem = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            addName = txbAddItem.Text;

            if (addName == "")
            {
                MessageBox.Show("you have to fill in something.");
                return;
            }

            FillDatatable("SELECT Amount FROM groceriestable WHERE Name = '" + addName + "'");

            if (dataTable.Rows.Count > 0)
            {
                newItemcount = Convert.ToInt32(dataTable.Rows[0][0]);
                newItemcount += 1;

                ExecuteQuery("UPDATE groceriestable SET Amount = '" + newItemcount + "' WHERE Name= '" + addName + "';");
            }
            else
            {
                ExecuteQuery("INSERT INTO groceriestable (Name, Amount) VALUES ('" + addName + "', 1)");
            }
        }

        private void UpdateListbox()
        {
            lbxItemlist.Items.Clear();
            row = 0;

            FillDatatable("SELECT * FROM groceriestable");

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow rows in dataTable.Rows)
                {
                    lbxItemlist.Items.Add((dataTable.Rows[row][0] + "" + dataTable.Rows[row][1]).ToString());
                    row++;
                }
            }
            else
            {
                MessageBox.Show("No items found, add new items to fill the list");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListbox();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            deleteItemname = selectedItem;

            FillDatatable("SELECT Amount FROM groceriestable WHERE Name = '" + deleteItemname + "'");
            if (dataTable.Rows.Count > 0)
            {
                newItemcount = Convert.ToInt32(dataTable.Rows[0][0]);
                if (newItemcount == 1)
                {
                    ExecuteQuery("DELETE FROM groceriestable WHERE Name ='" + deleteItemname + "';");
                }
                else
                {
                    newItemcount -= 1;
                    ExecuteQuery("UPDATE groceriestable SET Amount ='" + newItemcount + "'WHERE Name = '" + deleteItemname + "';");
                }
                UpdateListbox();
            }
        }

        private void lbxItemlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxItemlist.SelectedItem != null)
            {
                selectedItem = lbxItemlist.SelectedItem.ToString();
                selectedItem = Regex.Replace(selectedItem, @"\d", "");
                selectedItem.Trim();
                txbAddItem.Text = selectedItem;
            }
        }

        public void ExecuteQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (dataTable = new DataTable("Groceries"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            UpdateListbox();
        }

        public void FillDatatable(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (dataTable = new DataTable("Groceries"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                    }
                }
            }
        }
    }
}
