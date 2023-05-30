
namespace InventoryMngmt.UC
{
    partial class UC_Returns
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
            this.breakdownDGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.stockDGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.UClblHomepage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.breakdownDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // breakdownDGrid
            // 
            this.breakdownDGrid.AllowUserToResizeColumns = false;
            this.breakdownDGrid.AllowUserToResizeRows = false;
            this.breakdownDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.breakdownDGrid.BackgroundColor = System.Drawing.Color.White;
            this.breakdownDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.breakdownDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.breakdownDGrid.Location = new System.Drawing.Point(45, 360);
            this.breakdownDGrid.Name = "breakdownDGrid";
            this.breakdownDGrid.ReadOnly = true;
            this.breakdownDGrid.RowHeadersVisible = false;
            this.breakdownDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.breakdownDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.breakdownDGrid.Size = new System.Drawing.Size(737, 210);
            this.breakdownDGrid.TabIndex = 36;
            this.breakdownDGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.breakdownDGrid_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Product ID";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(23, 180);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(205, 20);
            this.txtQty.TabIndex = 75;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(23, 132);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.ReadOnly = true;
            this.txtProdName.Size = new System.Drawing.Size(205, 20);
            this.txtProdName.TabIndex = 74;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(23, 81);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(203, 20);
            this.txtProductID.TabIndex = 73;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(52)))), ((int)(((byte)(85)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(68, 279);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 31);
            this.btnRemove.TabIndex = 79;
            this.btnRemove.Text = "Dispose Item/s";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // stockDGrid
            // 
            this.stockDGrid.AllowUserToResizeColumns = false;
            this.stockDGrid.AllowUserToResizeRows = false;
            this.stockDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDGrid.BackgroundColor = System.Drawing.Color.White;
            this.stockDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stockDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stockDGrid.Location = new System.Drawing.Point(273, 76);
            this.stockDGrid.Name = "stockDGrid";
            this.stockDGrid.ReadOnly = true;
            this.stockDGrid.RowHeadersVisible = false;
            this.stockDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDGrid.Size = new System.Drawing.Size(530, 194);
            this.stockDGrid.TabIndex = 81;
            this.stockDGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDGrid_CellClick);
            this.stockDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDGrid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(714, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Stock List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Disposed Items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(23, 230);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(205, 40);
            this.txtDesc.TabIndex = 84;
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.Location = new System.Drawing.Point(669, 321);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(113, 31);
            this.btnFinal.TabIndex = 86;
            this.btnFinal.Text = "Finalize";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(52)))), ((int)(((byte)(85)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(544, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 31);
            this.btnCancel.TabIndex = 87;
            this.btnCancel.Text = "Remove";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 89;
            this.label7.Text = "Transac No.";
            // 
            // txtTransID
            // 
            this.txtTransID.Location = new System.Drawing.Point(380, 50);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(101, 20);
            this.txtTransID.TabIndex = 88;
            // 
            // UClblHomepage
            // 
            this.UClblHomepage.AutoSize = true;
            this.UClblHomepage.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClblHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.UClblHomepage.Location = new System.Drawing.Point(16, 12);
            this.UClblHomepage.Name = "UClblHomepage";
            this.UClblHomepage.Size = new System.Drawing.Size(195, 29);
            this.UClblHomepage.TabIndex = 117;
            this.UClblHomepage.Text = "Defective Items";
            // 
            // UC_Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UClblHomepage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stockDGrid);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.breakdownDGrid);
            this.Name = "UC_Returns";
            this.Size = new System.Drawing.Size(830, 600);
            this.Load += new System.EventHandler(this.UC_Returns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breakdownDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView breakdownDGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView stockDGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label UClblHomepage;
    }
}
