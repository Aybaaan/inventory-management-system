
namespace InventoryMngmt.UC
{
    partial class UC_Homepage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UClblHomepage = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPriceUnit = new System.Windows.Forms.TextBox();
            this.listBoxProd = new System.Windows.Forms.ListBox();
            this.ordersDGrid = new System.Windows.Forms.DataGridView();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.stockDGrid = new System.Windows.Forms.DataGridView();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOrdr = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UClblHomepage
            // 
            this.UClblHomepage.AutoSize = true;
            this.UClblHomepage.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClblHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.UClblHomepage.Location = new System.Drawing.Point(16, 12);
            this.UClblHomepage.Name = "UClblHomepage";
            this.UClblHomepage.Size = new System.Drawing.Size(94, 29);
            this.UClblHomepage.TabIndex = 1;
            this.UClblHomepage.Text = "Orders";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(22, 457);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(203, 20);
            this.txtSubtotal.TabIndex = 61;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(22, 363);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(205, 20);
            this.txtQty.TabIndex = 60;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(22, 315);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.ReadOnly = true;
            this.txtProdName.Size = new System.Drawing.Size(205, 20);
            this.txtProdName.TabIndex = 59;
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(22, 264);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(203, 20);
            this.txtProdID.TabIndex = 58;
            this.txtProdID.TextChanged += new System.EventHandler(this.txtProdID_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(94, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 22);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtPriceUnit
            // 
            this.txtPriceUnit.Location = new System.Drawing.Point(22, 408);
            this.txtPriceUnit.Name = "txtPriceUnit";
            this.txtPriceUnit.ReadOnly = true;
            this.txtPriceUnit.Size = new System.Drawing.Size(205, 20);
            this.txtPriceUnit.TabIndex = 65;
            this.txtPriceUnit.TextChanged += new System.EventHandler(this.txtPriceUnit_TextChanged);
            // 
            // listBoxProd
            // 
            this.listBoxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProd.FormattingEnabled = true;
            this.listBoxProd.ItemHeight = 18;
            this.listBoxProd.Location = new System.Drawing.Point(22, 98);
            this.listBoxProd.Name = "listBoxProd";
            this.listBoxProd.Size = new System.Drawing.Size(259, 112);
            this.listBoxProd.TabIndex = 66;
            this.listBoxProd.SelectedIndexChanged += new System.EventHandler(this.listBoxProd_SelectedIndexChanged);
            // 
            // ordersDGrid
            // 
            this.ordersDGrid.AllowUserToResizeColumns = false;
            this.ordersDGrid.AllowUserToResizeRows = false;
            this.ordersDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDGrid.BackgroundColor = System.Drawing.Color.White;
            this.ordersDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ordersDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ordersDGrid.Location = new System.Drawing.Point(259, 275);
            this.ordersDGrid.Name = "ordersDGrid";
            this.ordersDGrid.RowHeadersVisible = false;
            this.ordersDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDGrid.Size = new System.Drawing.Size(538, 223);
            this.ordersDGrid.TabIndex = 67;
            this.ordersDGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDGrid_CellClick);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(355, 523);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(90, 31);
            this.btnOrder.TabIndex = 68;
            this.btnOrder.Text = "Insert Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(52)))), ((int)(((byte)(85)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(259, 523);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 31);
            this.btnRemove.TabIndex = 69;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Quantity";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(22, 501);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Price per Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Order Date";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.DimGray;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(573, 534);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 20);
            this.lblTotal.TabIndex = 79;
            this.lblTotal.Text = "--";
            // 
            // stockDGrid
            // 
            this.stockDGrid.AllowUserToResizeColumns = false;
            this.stockDGrid.AllowUserToResizeRows = false;
            this.stockDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDGrid.BackgroundColor = System.Drawing.Color.White;
            this.stockDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stockDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stockDGrid.Location = new System.Drawing.Point(322, 98);
            this.stockDGrid.Name = "stockDGrid";
            this.stockDGrid.ReadOnly = true;
            this.stockDGrid.RowHeadersVisible = false;
            this.stockDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDGrid.Size = new System.Drawing.Size(475, 147);
            this.stockDGrid.TabIndex = 80;
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.btnRefresh2.FlatAppearance.BorderSize = 0;
            this.btnRefresh2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh2.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh2.ForeColor = System.Drawing.Color.White;
            this.btnRefresh2.Location = new System.Drawing.Point(735, 60);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(62, 31);
            this.btnRefresh2.TabIndex = 81;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = false;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(20, 548);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(205, 20);
            this.txtCustName.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Customer Name";
            // 
            // btnOrdr
            // 
            this.btnOrdr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.btnOrdr.FlatAppearance.BorderSize = 0;
            this.btnOrdr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdr.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdr.ForeColor = System.Drawing.Color.White;
            this.btnOrdr.Location = new System.Drawing.Point(717, 523);
            this.btnOrdr.Name = "btnOrdr";
            this.btnOrdr.Size = new System.Drawing.Size(80, 31);
            this.btnOrdr.TabIndex = 84;
            this.btnOrdr.Text = "Order";
            this.btnOrdr.UseVisualStyleBackColor = false;
            this.btnOrdr.Click += new System.EventHandler(this.btnOrdr_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(402, 66);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(112, 22);
            this.txtOrderID.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 86;
            this.label9.Text = "Item No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 87;
            this.label10.Text = "Search";
            // 
            // UC_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.btnOrdr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.btnRefresh2);
            this.Controls.Add(this.stockDGrid);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.ordersDGrid);
            this.Controls.Add(this.listBoxProd);
            this.Controls.Add(this.txtPriceUnit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.UClblHomepage);
            this.Name = "UC_Homepage";
            this.Size = new System.Drawing.Size(830, 600);
            this.Load += new System.EventHandler(this.UC_Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UClblHomepage;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPriceUnit;
        private System.Windows.Forms.ListBox listBoxProd;
        private System.Windows.Forms.DataGridView ordersDGrid;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView stockDGrid;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOrdr;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
