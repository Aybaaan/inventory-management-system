
namespace InventoryMngmt.UC
{
    partial class UC_Categories
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
            this.catBtnDelete = new System.Windows.Forms.Button();
            this.catBtnEdit = new System.Windows.Forms.Button();
            this.catBtnAdd = new System.Windows.Forms.Button();
            this.categoryDGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.catTxtName = new System.Windows.Forms.TextBox();
            this.catTxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UClblHomepage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // catBtnDelete
            // 
            this.catBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(52)))), ((int)(((byte)(85)))));
            this.catBtnDelete.FlatAppearance.BorderSize = 0;
            this.catBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtnDelete.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtnDelete.ForeColor = System.Drawing.Color.White;
            this.catBtnDelete.Location = new System.Drawing.Point(249, 264);
            this.catBtnDelete.Name = "catBtnDelete";
            this.catBtnDelete.Size = new System.Drawing.Size(75, 39);
            this.catBtnDelete.TabIndex = 19;
            this.catBtnDelete.Text = "Delete";
            this.catBtnDelete.UseVisualStyleBackColor = false;
            this.catBtnDelete.Click += new System.EventHandler(this.catBtnDelete_Click);
            // 
            // catBtnEdit
            // 
            this.catBtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.catBtnEdit.FlatAppearance.BorderSize = 0;
            this.catBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtnEdit.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtnEdit.ForeColor = System.Drawing.Color.White;
            this.catBtnEdit.Location = new System.Drawing.Point(143, 264);
            this.catBtnEdit.Name = "catBtnEdit";
            this.catBtnEdit.Size = new System.Drawing.Size(75, 39);
            this.catBtnEdit.TabIndex = 18;
            this.catBtnEdit.Text = "Edit";
            this.catBtnEdit.UseVisualStyleBackColor = false;
            this.catBtnEdit.Click += new System.EventHandler(this.catBtnEdit_Click);
            // 
            // catBtnAdd
            // 
            this.catBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.catBtnAdd.FlatAppearance.BorderSize = 0;
            this.catBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtnAdd.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catBtnAdd.ForeColor = System.Drawing.Color.White;
            this.catBtnAdd.Location = new System.Drawing.Point(40, 264);
            this.catBtnAdd.Name = "catBtnAdd";
            this.catBtnAdd.Size = new System.Drawing.Size(75, 39);
            this.catBtnAdd.TabIndex = 17;
            this.catBtnAdd.Text = "Add";
            this.catBtnAdd.UseVisualStyleBackColor = false;
            this.catBtnAdd.Click += new System.EventHandler(this.catBtnAdd_Click);
            // 
            // categoryDGrid
            // 
            this.categoryDGrid.AllowUserToResizeColumns = false;
            this.categoryDGrid.AllowUserToResizeRows = false;
            this.categoryDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDGrid.BackgroundColor = System.Drawing.Color.White;
            this.categoryDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoryDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.categoryDGrid.Location = new System.Drawing.Point(410, 65);
            this.categoryDGrid.Name = "categoryDGrid";
            this.categoryDGrid.ReadOnly = true;
            this.categoryDGrid.RowHeadersVisible = false;
            this.categoryDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.categoryDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryDGrid.Size = new System.Drawing.Size(358, 420);
            this.categoryDGrid.TabIndex = 20;
            this.categoryDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Category Name";
            // 
            // catTxtName
            // 
            this.catTxtName.Location = new System.Drawing.Point(170, 195);
            this.catTxtName.Name = "catTxtName";
            this.catTxtName.Size = new System.Drawing.Size(205, 20);
            this.catTxtName.TabIndex = 23;
            this.catTxtName.TextChanged += new System.EventHandler(this.catTxtName_TextChanged);
            // 
            // catTxtID
            // 
            this.catTxtID.Location = new System.Drawing.Point(170, 139);
            this.catTxtID.Name = "catTxtID";
            this.catTxtID.Size = new System.Drawing.Size(203, 20);
            this.catTxtID.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Category ID:";
            // 
            // UClblHomepage
            // 
            this.UClblHomepage.AutoSize = true;
            this.UClblHomepage.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClblHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.UClblHomepage.Location = new System.Drawing.Point(16, 12);
            this.UClblHomepage.Name = "UClblHomepage";
            this.UClblHomepage.Size = new System.Drawing.Size(164, 29);
            this.UClblHomepage.TabIndex = 117;
            this.UClblHomepage.Text = "Classification";
            // 
            // UC_Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UClblHomepage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.catTxtName);
            this.Controls.Add(this.catTxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryDGrid);
            this.Controls.Add(this.catBtnDelete);
            this.Controls.Add(this.catBtnEdit);
            this.Controls.Add(this.catBtnAdd);
            this.Name = "UC_Categories";
            this.Size = new System.Drawing.Size(830, 600);
            this.Load += new System.EventHandler(this.UC_Categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button catBtnDelete;
        private System.Windows.Forms.Button catBtnEdit;
        private System.Windows.Forms.Button catBtnAdd;
        private System.Windows.Forms.DataGridView categoryDGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catTxtName;
        private System.Windows.Forms.TextBox catTxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UClblHomepage;
    }
}
