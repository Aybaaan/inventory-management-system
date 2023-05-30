
namespace InventoryMngmt.UC
{
    partial class UC_Orders
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
            this.UClblManageAccount = new System.Windows.Forms.Label();
            this.stockDGrid = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.stockCboxSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderTxtName = new System.Windows.Forms.TextBox();
            this.orderTxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOrders = new System.Windows.Forms.DateTimePicker();
            this.OrdersDGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.orderTxtQty = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UClblManageAccount
            // 
            this.UClblManageAccount.AutoSize = true;
            this.UClblManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClblManageAccount.Location = new System.Drawing.Point(14, 12);
            this.UClblManageAccount.Name = "UClblManageAccount";
            this.UClblManageAccount.Size = new System.Drawing.Size(83, 25);
            this.UClblManageAccount.TabIndex = 34;
            this.UClblManageAccount.Text = "Orders";
            // 
            // stockDGrid
            // 
            this.stockDGrid.AllowUserToResizeColumns = false;
            this.stockDGrid.AllowUserToResizeRows = false;
            this.stockDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDGrid.BackgroundColor = System.Drawing.Color.White;
            this.stockDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stockDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stockDGrid.Location = new System.Drawing.Point(293, 72);
            this.stockDGrid.Name = "stockDGrid";
            this.stockDGrid.ReadOnly = true;
            this.stockDGrid.RowHeadersVisible = false;
            this.stockDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDGrid.Size = new System.Drawing.Size(493, 183);
            this.stockDGrid.TabIndex = 35;
            this.stockDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDGrid_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Aqua;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(711, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // stockCboxSearch
            // 
            this.stockCboxSearch.FormattingEnabled = true;
            this.stockCboxSearch.Location = new System.Drawing.Point(500, 41);
            this.stockCboxSearch.Name = "stockCboxSearch";
            this.stockCboxSearch.Size = new System.Drawing.Size(205, 21);
            this.stockCboxSearch.TabIndex = 37;
            this.stockCboxSearch.SelectedIndexChanged += new System.EventHandler(this.stockCboxSearch_SelectedIndexChanged);
            this.stockCboxSearch.SelectionChangeCommitted += new System.EventHandler(this.stockCboxSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Customer Name";
            // 
            // orderTxtName
            // 
            this.orderTxtName.Location = new System.Drawing.Point(36, 174);
            this.orderTxtName.Name = "orderTxtName";
            this.orderTxtName.Size = new System.Drawing.Size(205, 20);
            this.orderTxtName.TabIndex = 42;
            this.orderTxtName.TextChanged += new System.EventHandler(this.orderTxtName_TextChanged);
            // 
            // orderTxtID
            // 
            this.orderTxtID.Location = new System.Drawing.Point(36, 115);
            this.orderTxtID.Name = "orderTxtID";
            this.orderTxtID.Size = new System.Drawing.Size(203, 20);
            this.orderTxtID.TabIndex = 41;
            this.orderTxtID.TextChanged += new System.EventHandler(this.orderTxtID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Order ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Order Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateOrders
            // 
            this.dateOrders.CustomFormat = "MM/dd/yyyy";
            this.dateOrders.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOrders.Location = new System.Drawing.Point(36, 235);
            this.dateOrders.Name = "dateOrders";
            this.dateOrders.Size = new System.Drawing.Size(205, 20);
            this.dateOrders.TabIndex = 0;
            this.dateOrders.TabStop = false;
            this.dateOrders.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // OrdersDGrid
            // 
            this.OrdersDGrid.AllowUserToResizeColumns = false;
            this.OrdersDGrid.AllowUserToResizeRows = false;
            this.OrdersDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDGrid.BackgroundColor = System.Drawing.Color.White;
            this.OrdersDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrdersDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.OrdersDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrdersDGrid.Location = new System.Drawing.Point(36, 366);
            this.OrdersDGrid.Name = "OrdersDGrid";
            this.OrdersDGrid.RowHeadersVisible = false;
            this.OrdersDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrdersDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDGrid.Size = new System.Drawing.Size(750, 151);
            this.OrdersDGrid.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Order Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Product Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Subtotal";
            this.Column7.Name = "Column7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // orderTxtQty
            // 
            this.orderTxtQty.Location = new System.Drawing.Point(477, 324);
            this.orderTxtQty.Name = "orderTxtQty";
            this.orderTxtQty.Size = new System.Drawing.Size(118, 20);
            this.orderTxtQty.TabIndex = 47;
            this.orderTxtQty.TextChanged += new System.EventHandler(this.stockTxtQty_TextChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Aqua;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(601, 318);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(89, 31);
            this.btnOrder.TabIndex = 49;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Total:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(517, 535);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(47, 24);
            this.total.TabIndex = 51;
            this.total.Text = "Php";
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.BackColor = System.Drawing.Color.Aqua;
            this.btnInsertOrder.FlatAppearance.BorderSize = 0;
            this.btnInsertOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertOrder.Location = new System.Drawing.Point(697, 524);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(89, 36);
            this.btnInsertOrder.TabIndex = 52;
            this.btnInsertOrder.Text = "Insert Order";
            this.btnInsertOrder.UseVisualStyleBackColor = false;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.Aqua;
            this.btnViewOrder.FlatAppearance.BorderSize = 0;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Location = new System.Drawing.Point(36, 297);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(203, 31);
            this.btnViewOrder.TabIndex = 53;
            this.btnViewOrder.Text = "View Orders";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Aqua;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(696, 318);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 31);
            this.btnRemove.TabIndex = 54;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 55;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(418, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Price per Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 58;
            this.label7.Text = "Subtotal";
            // 
            // UC_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnInsertOrder);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderTxtQty);
            this.Controls.Add(this.OrdersDGrid);
            this.Controls.Add(this.dateOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderTxtName);
            this.Controls.Add(this.orderTxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.stockCboxSearch);
            this.Controls.Add(this.stockDGrid);
            this.Controls.Add(this.UClblManageAccount);
            this.Name = "UC_Orders";
            this.Size = new System.Drawing.Size(830, 600);
            this.Load += new System.EventHandler(this.UC_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UClblManageAccount;
        private System.Windows.Forms.DataGridView stockDGrid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox stockCboxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderTxtName;
        private System.Windows.Forms.TextBox orderTxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOrders;
        private System.Windows.Forms.DataGridView OrdersDGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderTxtQty;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
