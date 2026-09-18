namespace quizLogic
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
            this.btnAddList = new System.Windows.Forms.Button();
            this.txbAddList = new System.Windows.Forms.TextBox();
            this.lbxWishlist = new System.Windows.Forms.ListBox();
            this.lbxGiftslist = new System.Windows.Forms.ListBox();
            this.lbxAllGifts = new System.Windows.Forms.ListBox();
            this.btnAddGiftToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(12, 12);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(184, 23);
            this.btnAddList.TabIndex = 0;
            this.btnAddList.Text = "New List";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // txbAddList
            // 
            this.txbAddList.Location = new System.Drawing.Point(13, 42);
            this.txbAddList.Name = "txbAddList";
            this.txbAddList.Size = new System.Drawing.Size(183, 20);
            this.txbAddList.TabIndex = 1;
            // 
            // lbxWishlist
            // 
            this.lbxWishlist.FormattingEnabled = true;
            this.lbxWishlist.Location = new System.Drawing.Point(13, 69);
            this.lbxWishlist.Name = "lbxWishlist";
            this.lbxWishlist.Size = new System.Drawing.Size(183, 368);
            this.lbxWishlist.TabIndex = 2;
            this.lbxWishlist.SelectedIndexChanged += new System.EventHandler(this.lbxWishlist_SelectedIndexChanged);
            // 
            // lbxGiftslist
            // 
            this.lbxGiftslist.FormattingEnabled = true;
            this.lbxGiftslist.Location = new System.Drawing.Point(202, 18);
            this.lbxGiftslist.Name = "lbxGiftslist";
            this.lbxGiftslist.Size = new System.Drawing.Size(183, 420);
            this.lbxGiftslist.TabIndex = 3;
            // 
            // lbxAllGifts
            // 
            this.lbxAllGifts.FormattingEnabled = true;
            this.lbxAllGifts.Location = new System.Drawing.Point(391, 69);
            this.lbxAllGifts.Name = "lbxAllGifts";
            this.lbxAllGifts.Size = new System.Drawing.Size(183, 368);
            this.lbxAllGifts.TabIndex = 4;
            this.lbxAllGifts.SelectedIndexChanged += new System.EventHandler(this.lbxAllGifts_SelectedIndexChanged);
            // 
            // btnAddGiftToList
            // 
            this.btnAddGiftToList.Location = new System.Drawing.Point(391, 12);
            this.btnAddGiftToList.Name = "btnAddGiftToList";
            this.btnAddGiftToList.Size = new System.Drawing.Size(184, 50);
            this.btnAddGiftToList.TabIndex = 5;
            this.btnAddGiftToList.Text = "Add Gift to List";
            this.btnAddGiftToList.UseVisualStyleBackColor = true;
            this.btnAddGiftToList.Click += new System.EventHandler(this.btnAddGiftToList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btnAddGiftToList);
            this.Controls.Add(this.lbxAllGifts);
            this.Controls.Add(this.lbxGiftslist);
            this.Controls.Add(this.lbxWishlist);
            this.Controls.Add(this.txbAddList);
            this.Controls.Add(this.btnAddList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.TextBox txbAddList;
        private System.Windows.Forms.ListBox lbxWishlist;
        private System.Windows.Forms.ListBox lbxGiftslist;
        private System.Windows.Forms.ListBox lbxAllGifts;
        private System.Windows.Forms.Button btnAddGiftToList;
    }
}

