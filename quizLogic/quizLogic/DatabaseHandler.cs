using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace quizLogic
{
    internal class DatabaseHandler
    {

        string connectionstring = "Server=localhost;Port=3306;Database=c#test;Uid=root;Pwd=;";
        DataTable dataTable = null;
        int row = 0;

        public void UpdateListbox(ListBox lbxChangeBox, string tableName)
        {
            lbxChangeBox.Items.Clear();
            row = 0;

            FillDatatable("SELECT * FROM " + tableName);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow rows in dataTable.Rows)
                {
                    lbxChangeBox.Items.Add(dataTable.Rows[row][1]).ToString();
                    row++;
                }
            }
            else
            {
                MessageBox.Show("No items found, add new items to fill the list.");
            }
        }

        public void ShowAllGiftsForSelectedWishList(ListBox lbxListbox, int selectedListId)
        {
            List<int> giftsFound = new List<int>();
            lbxListbox.Items.Clear();
            row = 0;

            FillDatatable("SELECT * FROM giftlist_gifts WHERE fk_giftlistid = " + selectedListId);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow rows in dataTable.Rows)
                {
                    giftsFound.Add(Convert.ToInt32(dataTable.Rows[row][2]));
                    row++;
                }

                foreach (int giftId in giftsFound)
                {
                    FillDatatable("SELECT Gift FROM gifts WHERE GiftsId = " + giftId);
                    lbxListbox.Items.Add(dataTable.Rows[0][0]).ToString();
                }
            }
            else
            {
                MessageBox.Show("No items found, add new items to fill the list.");
            }
        }

        public void AddItemToSelectedWishlist(int wishlistid, int newItemid)
        {
            ExecuteQuery("INSERT INTO giftlist_gifts (fk_giftlistid, fk_giftid) VALUES (" + wishlistid + ", '" + newItemid + "')");
        }

        public void  FillDatatable(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (dataTable = new DataTable("WishList"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                    }
                }
            }
        }

        public void ExecuteQuery(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (dataTable = new DataTable("WishList"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void NewList(string newListName)
        {
            ExecuteQuery("INSERT INTO wishlist (Listname) VALUES ('" + newListName + "')");
        }
    }
}
