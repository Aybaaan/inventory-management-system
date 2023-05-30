
namespace InventoryMngmt.UC
{
    partial class UC_Stocks
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
            this.stockBtnDelete = new System.Windows.Forms.Button();
            this.stockBtnEdit = new System.Windows.Forms.Button();
            this.stockBtnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stockTxtPrice = new System.Windows.Forms.TextBox();
            this.stockTxtQty = new System.Windows.Forms.TextBox();
            this.stockTxtPName = new System.Windows.Forms.TextBox();
            this.stockTxtPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockDGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stockTxtDesc = new System.Windows.Forms.TextBox();
            this.stockCboxCat = new System.Windows.Forms.ComboBox();
            this.stockCboxSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.UClblHomepage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stockBtnDelete
            // 
            this.stockBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(52)))), ((int)(((byte)(85)))));
            this.stockBtnDelete.FlatAppearance.BorderSize = 0;
            this.stockBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtnDelete.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtnDelete.ForeColor = System.Drawing.Color.White;
            this.stockBtnDelete.Location = new System.Drawing.Point(201, 180);
            this.stockBtnDelete.Name = "stockBtnDelete";
            this.stockBtnDelete.Size = new System.Drawing.Size(75, 31);
            this.stockBtnDelete.TabIndex = 19;
            this.stockBtnDelete.Text = "Delete";
            this.stockBtnDelete.UseVisualStyleBackColor = false;
            this.stockBtnDelete.Click += new System.EventHandler(this.stockBtnDelete_Click);
            // 
            // stockBtnEdit
            // 
            this.stockBtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.stockBtnEdit.FlatAppearance.BorderSize = 0;
            this.stockBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtnEdit.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtnEdit.ForeColor = System.Drawing.Color.White;
            this.stockBtnEdit.Location = new System.Drawing.Point(120, 180);
            this.stockBtnEdit.Name = "stockBtnEdit";
            this.stockBtnEdit.Size = new System.Drawing.Size(75, 31);
            this.stockBtnEdit.TabIndex = 18;
            this.stockBtnEdit.Text = "Edit";
            this.stockBtnEdit.UseVisualStyleBackColor = false;
            this.stockBtnEdit.Click += new System.EventHandler(this.stockBtnEdit_Click);
            // 
            // stockBtnAdd
            // 
            this.stockBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.stockBtnAdd.FlatAppearance.BorderSize = 0;
            this.stockBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockBtnAdd.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockBtnAdd.ForeColor = System.Drawing.Color.White;
            this.stockBtnAdd.Location = new System.Drawing.Point(39, 180);
            this.stockBtnAdd.Name = "stockBtnAdd";
            this.stockBtnAdd.Size = new System.Drawing.Size(75, 31);
            this.stockBtnAdd.TabIndex = 17;
            this.stockBtnAdd.Text = "Add";
            this.stockBtnAdd.UseVisualStyleBackColor = false;
            this.stockBtnAdd.Click += new System.EventHandler(this.stockBtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Product Name";
            // 
            // stockTxtPrice
            // 
            this.stockTxtPrice.Location = new System.Drawing.Point(567, 62);
            this.stockTxtPrice.Name = "stockTxtPrice";
            this.stockTxtPrice.Size = new System.Drawing.Size(205, 20);
            this.stockTxtPrice.TabIndex = 24;
            // 
            // stockTxtQty
            // 
            this.stockTxtQty.Location = new System.Drawing.Point(182, 136);
            this.stockTxtQty.Name = "stockTxtQty";
            this.stockTxtQty.Size = new System.Drawing.Size(205, 20);
            this.stockTxtQty.TabIndex = 23;
            // 
            // stockTxtPName
            // 
            this.stockTxtPName.Location = new System.Drawing.Point(182, 96);
            this.stockTxtPName.Name = "stockTxtPName";
            this.stockTxtPName.Size = new System.Drawing.Size(205, 20);
            this.stockTxtPName.TabIndex = 22;
            // 
            // stockTxtPID
            // 
            this.stockTxtPID.Location = new System.Drawing.Point(183, 60);
            this.stockTxtPID.Name = "stockTxtPID";
            this.stockTxtPID.Size = new System.Drawing.Size(203, 20);
            this.stockTxtPID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product ID";
            // 
            // stockDGrid
            // 
            this.stockDGrid.AllowUserToResizeColumns = false;
            this.stockDGrid.AllowUserToResizeRows = false;
            this.stockDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDGrid.BackgroundColor = System.Drawing.Color.White;
            this.stockDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.stockDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stockDGrid.Location = new System.Drawing.Point(39, 217);
            this.stockDGrid.Name = "stockDGrid";
            this.stockDGrid.ReadOnly = true;
            this.stockDGrid.RowHeadersVisible = false;
            this.stockDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDGrid.Size = new System.Drawing.Size(748, 352);
            this.stockDGrid.TabIndex = 28;
            this.stockDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDGrid_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Description";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // stockTxtDesc
            // 
            this.stockTxtDesc.Location = new System.Drawing.Point(567, 96);
            this.stockTxtDesc.Name = "stockTxtDesc";
            this.stockTxtDesc.Size = new System.Drawing.Size(205, 20);
            this.stockTxtDesc.TabIndex = 30;
            // 
            // stockCboxCat
            // 
            this.stockCboxCat.FormattingEnabled = true;
            this.stockCboxCat.Location = new System.Drawing.Point(567, 132);
            this.stockCboxCat.Name = "stockCboxCat";
            this.stockCboxCat.Size = new System.Drawing.Size(205, 21);
            this.stockCboxCat.TabIndex = 32;
            this.stockCboxCat.SelectedIndexChanged += new System.EventHandler(this.stockCboxCat_SelectedIndexChanged);
            // 
            // stockCboxSearch
            // 
            this.stockCboxSearch.FormattingEnabled = true;
            this.stockCboxSearch.Location = new System.Drawing.Point(414, 186);
            this.stockCboxSearch.Name = "stockCboxSearch";
            this.stockCboxSearch.Size = new System.Drawing.Size(205, 21);
            this.stockCboxSearch.TabIndex = 34;
            this.stockCboxSearch.SelectedIndexChanged += new System.EventHandler(this.stockCboxSearch_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(631, 180);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(712, 180);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 31);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UClblHomepage
            // 
            this.UClblHomepage.AutoSize = true;
            this.UClblHomepage.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClblHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.UClblHomepage.Location = new System.Drawing.Point(16, 12);
            this.UClblHomepage.Name = "UClblHomepage";
            this.UClblHomepage.Size = new System.Drawing.Size(88, 29);
            this.UClblHomepage.TabIndex = 116;
            this.UClblHomepage.Text = "Stocks";
            // 
            // UC_Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UClblHomepage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.stockCboxSearch);
            this.Controls.Add(this.stockCboxCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stockTxtDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stockDGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockTxtPrice);
            this.Controls.Add(this.stockTxtQty);
            this.Controls.Add(this.stockTxtPName);
            this.Controls.Add(this.stockTxtPID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockBtnDelete);
            this.Controls.Add(this.stockBtnEdit);
            this.Controls.Add(this.stockBtnAdd);
            this.Name = "UC_Stocks";
            this.Size = new System.Drawing.Size(830, 600);
            this.Load += new System.EventHandler(this.UC_Stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stockBtnDelete;
        private System.Windows.Forms.Button stockBtnEdit;
        private System.Windows.Forms.Button stockBtnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stockTxtPrice;
        private System.Windows.Forms.TextBox stockTxtQty;
        private System.Windows.Forms.TextBox stockTxtPName;
        private System.Windows.Forms.TextBox stockTxtPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stockDGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stockTxtDesc;
        private System.Windows.Forms.ComboBox stockCboxCat;
        private System.Windows.Forms.ComboBox stockCboxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label UClblHomepage;
    }
}
