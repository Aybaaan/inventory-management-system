
namespace InventoryMngmt
{
    partial class OrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderList));
            this.UClblManageAccount = new System.Windows.Forms.Label();
            this.orderlistDGrid = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UClblManageAccount
            // 
            this.UClblManageAccount.AutoSize = true;
            this.UClblManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClblManageAccount.Location = new System.Drawing.Point(225, 19);
            this.UClblManageAccount.Name = "UClblManageAccount";
            this.UClblManageAccount.Size = new System.Drawing.Size(181, 25);
            this.UClblManageAccount.TabIndex = 36;
            this.UClblManageAccount.Text = "Transaction List";
            // 
            // orderlistDGrid
            // 
            this.orderlistDGrid.AllowUserToResizeColumns = false;
            this.orderlistDGrid.AllowUserToResizeRows = false;
            this.orderlistDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderlistDGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderlistDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderlistDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orderlistDGrid.Location = new System.Drawing.Point(23, 73);
            this.orderlistDGrid.Name = "orderlistDGrid";
            this.orderlistDGrid.ReadOnly = true;
            this.orderlistDGrid.RowHeadersVisible = false;
            this.orderlistDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.orderlistDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderlistDGrid.Size = new System.Drawing.Size(602, 427);
            this.orderlistDGrid.TabIndex = 37;
            this.orderlistDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderlistDGrid_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Aqua;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(276, 518);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 31);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 572);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.orderlistDGrid);
            this.Controls.Add(this.UClblManageAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderlistDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UClblManageAccount;
        private System.Windows.Forms.DataGridView orderlistDGrid;
        private System.Windows.Forms.Button btnBack;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}