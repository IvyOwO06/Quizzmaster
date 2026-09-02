using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDatabase_Search
{
    public partial class Form1 : Form
    {

        // connection string to the database
        string connectionString = "Server=localhost;Port=3306;Database=c#test;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                FillDatagridview();
            }
            else
            {
                using (MySqlConnection mysqlConnection = new MySqlConnection(connectionString))
                {
                    // if the connection is closed, this'll open it
                    if (mysqlConnection.State == ConnectionState.Closed)
                    {
                        mysqlConnection.Open();
                    }

                    // use a data table to hold the results of the query
                    using (DataTable datatable = new DataTable())
                    {
                        // create a mysql command to execute the query
                        using (MySqlCommand command = new MySqlCommand("SELECT * FROM games WHERE Ranking = @Ranking", mysqlConnection))
                        {
                            // add the parameter to the command to prevent sql injection
                            command.Parameters.AddWithValue("@Ranking", tbxSearch.Text);
                            // create a sqlDataAdapter to fill the datatable with the results of the query
                            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
                            // clear the DataTable before filling it
                            mySqlDataAdapter.Fill(datatable);
                            // set the datasource of the datagridview to the datatable
                            dvgInformation.DataSource = datatable;

                        }
                    }
                }
            }
            ResetDvgSize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDatagridview();
        }

        private void FillDatagridview()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                // if the connection is closed, this'll open it
                if (mySqlConnection.State == ConnectionState.Closed)
                {
                    mySqlConnection.Open();
                }

                // create a data table to hold the results of the query
                using (DataTable datatable = new DataTable()) 
                {
                    // create a sql command to execute the query
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM games", mySqlConnection))
                    {
                        // create a mySqlDataAdapter to fill the datatable with the results of the query
                        MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
                        //clear the datatable before filling it
                        mySqlDataAdapter.Fill(datatable);
                        // set the datasource of the datagridview to the datatable
                        dvgInformation.DataSource = datatable;
                    }
                }
            }
            ResetDvgSize();
        }

        private void ResetDvgSize()
        {
            // makes sure the datagridview is able to change its size
            dvgInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // calculates the total width of the datagridview
            int totalwidth = dvgInformation.RowHeadersWidth;

            foreach (DataGridViewColumn column in dvgInformation.Columns)
            {
                totalwidth += column.Width;
            }

            // changes the width of the datagridview + 20 to make sure everything fits
            dvgInformation.Width = totalwidth + 20;

            // changes the width of the form
            this.Width = totalwidth + 50;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
            FillDatagridview();
        }
    }
}
