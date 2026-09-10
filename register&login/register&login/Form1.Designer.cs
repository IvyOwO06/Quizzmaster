namespace register_login
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
            this.lblAddItem = new System.Windows.Forms.Label();
            this.txbAddItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lbxItemlist = new System.Windows.Forms.ListBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Location = new System.Drawing.Point(13, 13);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(51, 13);
            this.lblAddItem.TabIndex = 0;
            this.lblAddItem.Text = "Add item:";
            // 
            // txbAddItem
            // 
            this.txbAddItem.Location = new System.Drawing.Point(71, 13);
            this.txbAddItem.Name = "txbAddItem";
            this.txbAddItem.Size = new System.Drawing.Size(100, 20);
            this.txbAddItem.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(16, 39);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(155, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lbxItemlist
            // 
            this.lbxItemlist.FormattingEnabled = true;
            this.lbxItemlist.Location = new System.Drawing.Point(16, 69);
            this.lbxItemlist.Name = "lbxItemlist";
            this.lbxItemlist.Size = new System.Drawing.Size(155, 160);
            this.lbxItemlist.TabIndex = 3;
            this.lbxItemlist.SelectedIndexChanged += new System.EventHandler(this.lbxItemlist_SelectedIndexChanged);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(16, 235);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(155, 23);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "Delete item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 274);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lbxItemlist);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txbAddItem);
            this.Controls.Add(this.lblAddItem);
            this.Name = "Form1";
            this.Text = "Groceries";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.TextBox txbAddItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lbxItemlist;
        private System.Windows.Forms.Button btnDeleteItem;
    }
}

