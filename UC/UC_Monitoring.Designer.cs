
namespace InventoryMngmt.UC
{
    partial class UC_Monitoring
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnCStock = new System.Windows.Forms.Button();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.ordersDGrid = new System.Windows.Forms.DataGridView();
            this.breakdownGrid = new System.Windows.Forms.DataGridView();
            this.TransferDGrid = new System.Windows.Forms.DataGridView();
            this.btnDispose = new System.Windows.Forms.Button();
            this.disposeDGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakdownGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposeDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(173, 76);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(112, 35);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(303, 76);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(116, 35);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Stock Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnCStock
            // 
            this.btnCStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCStock.Location = new System.Drawing.Point(38, 76);
            this.btnCStock.Name = "btnCStock";
            this.btnCStock.Size = new System.Drawing.Size(116, 35);
            this.btnCStock.TabIndex = 4;
            this.btnCStock.Text = "Current Stocks";
            this.btnCStock.UseVisualStyleBackColor = true;
            this.btnCStock.Click += new System.EventHandler(this.btnCStock_Click);
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.btnRefresh2.FlatAppearance.BorderSize = 0;
            this.btnRefresh2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh2.ForeColor = System.Drawing.Color.White;
            this.btnRefresh2.Location = new System.Drawing.Point(712, 76);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(80, 35);
            this.btnRefresh2.TabIndex = 82;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = false;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // ordersDGrid
            // 
            this.ordersDGrid.AllowUserToResizeColumns = false;
            this.ordersDGrid.AllowUserToResizeRows = false;
            this.ordersDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDGrid.BackgroundColor = System.Drawing.Color.White;
            this.ordersDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ordersDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ordersDGrid.Location = new System.Drawing.Point(38, 117);
            this.ordersDGrid.Name = "ordersDGrid";
            this.ordersDGrid.RowHeadersVisible = false;
            this.ordersDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDGrid.Size = new System.Drawing.Size(754, 457);
            this.ordersDGrid.TabIndex = 83;
            this.ordersDGrid.Visible = false;
            // 
            // breakdownGrid
            // 
            this.breakdownGrid.AllowUserToResizeColumns = false;
            this.breakdownGrid.AllowUserToResizeRows = false;
            this.breakdownGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.breakdownGrid.BackgroundColor = System.Drawing.Color.White;
            this.breakdownGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.breakdownGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.breakdownGrid.Location = new System.Drawing.Point(38, 117);
            this.breakdownGrid.Name = "breakdownGrid";
            this.breakdownGrid.RowHeadersVisible = false;
            this.breakdownGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.breakdownGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.breakdownGrid.Size = new System.Drawing.Size(754, 457);
            this.breakdownGrid.TabIndex = 84;
            this.breakdownGrid.Visible = false;
            // 
            // TransferDGrid
            // 
            this.TransferDGrid.AllowUserToResizeColumns = false;
            this.TransferDGrid.AllowUserToResizeRows = false;
            this.TransferDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransferDGrid.BackgroundColor = System.Drawing.Color.White;
            this.TransferDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TransferDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TransferDGrid.Location = new System.Drawing.Point(38, 117);
            this.TransferDGrid.Name = "TransferDGrid";
            this.TransferDGrid.RowHeadersVisible = false;
            this.TransferDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TransferDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransferDGrid.Size = new System.Drawing.Size(754, 457);
            this.TransferDGrid.TabIndex = 109;
            this.TransferDGrid.Visible = false;
            // 
            // btnDispose
            // 
            this.btnDispose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispose.Location = new System.Drawing.Point(436, 76);
            this.btnDispose.Name = "btnDispose";
            this.btnDispose.Size = new System.Drawing.Size(116, 35);
            this.btnDispose.TabIndex = 110;
            this.btnDispose.Text = "Disposed Items";
            this.btnDispose.UseVisualStyleBackColor = true;
            this.btnDispose.Click += new System.EventHandler(this.btnDispose_Click);
            // 
            // disposeDGrid
            // 
            this.disposeDGrid.AllowUserToResizeColumns = false;
            this.disposeDGrid.AllowUserToResizeRows = false;
            this.disposeDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.disposeDGrid.BackgroundColor = System.Drawing.Color.White;
            this.disposeDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.disposeDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.disposeDGrid.Location = new System.Drawing.Point(38, 117);
            this.disposeDGrid.Name = "disposeDGrid";
            this.disposeDGrid.ReadOnly = true;
            this.disposeDGrid.RowHeadersVisible = false;
            this.disposeDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.disposeDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.disposeDGrid.Size = new System.Drawing.Size(754, 457);
            this.disposeDGrid.TabIndex = 111;
            this.disposeDGrid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 112;
            this.label1.Text = "Records";
            // 
            // UC_Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disposeDGrid);
            this.Controls.Add(this.btnDispose);
            this.Controls.Add(this.TransferDGrid);
            this.Controls.Add(this.breakdownGrid);
            this.Controls.Add(this.ordersDGrid);
            this.Controls.Add(this.btnRefresh2);
            this.Controls.Add(this.btnCStock);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnOrders);
            this.Name = "UC_Monitoring";
            this.Size = new System.Drawing.Size(830, 600);
            this.Load += new System.EventHandler(this.UC_Monitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakdownGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransferDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposeDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCStock;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.DataGridView ordersDGrid;
        private System.Windows.Forms.DataGridView breakdownGrid;
        private System.Windows.Forms.DataGridView TransferDGrid;
        private System.Windows.Forms.Button btnDispose;
        private System.Windows.Forms.DataGridView disposeDGrid;
        private System.Windows.Forms.Label label1;
    }
}
