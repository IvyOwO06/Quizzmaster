using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizLogic
{
    public partial class Form1 : Form
    {
        DatabaseHandler databaseHandler = null;
        string selectedWishlist = "";
        string selectedGift = "";
        int selectedGiftId = -1;
        int selectedlistId = -1;
        string newWishlistName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            databaseHandler = new DatabaseHandler();
            btnAddGiftToList.Enabled = false;
            lbxAllGifts.Enabled = false;
            databaseHandler.UpdateListbox(lbxWishlist, "Wishlist");
            databaseHandler.UpdateListbox(lbxAllGifts, "Gifts");
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (txbAddList.Text != "")
            {
                newWishlistName = txbAddList.Text;
                databaseHandler.NewList(newWishlistName);
                databaseHandler.UpdateListbox(lbxWishlist, "Wishlist");
            }
        }

        private void lbxWishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxWishlist.SelectedItem != null)
            {
                selectedlistId = lbxWishlist.SelectedIndex + 1;
                selectedWishlist = lbxWishlist.SelectedItem.ToString();
                btnAddGiftToList.Enabled = false;
                lbxAllGifts.Enabled = true;
                databaseHandler.ShowAllGiftsForSelectedWishList(lbxGiftslist, selectedlistId);
            }
        }

        private void lbxAllGifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAllGifts.SelectedItem != null)
            {
                selectedGiftId = lbxAllGifts.SelectedIndex + 1;
                selectedGift = lbxAllGifts.SelectedItem.ToString();
                btnAddGiftToList.Enabled = true;
            }
        }

        private void btnAddGiftToList_Click(object sender, EventArgs e)
        {
            databaseHandler.AddItemToSelectedWishlist(selectedlistId, selectedGiftId);
            databaseHandler.ShowAllGiftsForSelectedWishList(lbxGiftslist, selectedlistId);
        }
    }
}
