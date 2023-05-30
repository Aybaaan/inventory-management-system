
namespace InventoryMngmt.UC
{
    partial class UC_Partner
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
            this.partnerDGrid = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PartnerName = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtPartnerName = new System.Windows.Forms.TextBox();
            this.txtPartnerID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UClblHomepage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partnerDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // partnerDGrid
            // 
            this.partnerDGrid.AllowUserToResizeColumns = false;
            this.partnerDGrid.AllowUserToResizeRows = false;
            this.partnerDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partnerDGrid.BackgroundColor = System.Drawing.Color.White;
            this.partnerDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.partnerDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partnerDGrid.Location = new System.Drawing.Point(345, 76);
            this.partnerDGrid.Name = "partnerDGrid";
            this.partnerDGrid.ReadOnly = true;
            this.partnerDGrid.RowHeadersVisible = false;
            this.partnerDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.partnerDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partnerDGrid.Size = new System.Drawing.Size(445, 377);
            this.partnerDGrid.TabIndex = 29;
            this.partnerDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partnerDGrid_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(52)))), ((int)(((byte)(85)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(244, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(132, 312);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Contact No.";
            // 
            // PartnerName
            // 
            this.PartnerName.AutoSize = true;
            this.PartnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartnerName.Location = new System.Drawing.Point(20, 202);
            this.PartnerName.Name = "PartnerName";
            this.PartnerName.Size = new System.Drawing.Size(61, 24);
            this.PartnerName.TabIndex = 24;
            this.PartnerName.Text = "Name";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(128, 255);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(205, 20);
            this.txtContact.TabIndex = 23;
            // 
            // txtPartnerName
            // 
            this.txtPartnerName.Location = new System.Drawing.Point(128, 206);
            this.txtPartnerName.Name = "txtPartnerName";
            this.txtPartnerName.Size = new System.Drawing.Size(205, 20);
            this.txtPartnerName.TabIndex = 21;
            // 
            // txtPartnerID
            // 
            this.txtPartnerID.Location = new System.Drawing.Point(128, 152);
            this.txtPartnerID.Name = "txtPartnerID";
            this.txtPartnerID.Size = new System.Drawing.Size(205, 20);
            this.txtPartnerID.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Partner ID";
            // 
            // UClblHomepage
            // 
            this.UClblHomepage.AutoSize = true;
            this.UClblHomepage.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClblHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.UClblHomepage.Location = new System.Drawing.Point(16, 12);
            this.UClblHomepage.Name = "UClblHomepage";
            this.UClblHomepage.Size = new System.Drawing.Size(315, 29);
            this.UClblHomepage.TabIndex = 116;
            this.UClblHomepage.Text = "Partners / Other Branches";
            // 
            // UC_Partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UClblHomepage);
            this.Controls.Add(this.partnerDGrid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PartnerName);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtPartnerName);
            this.Controls.Add(this.txtPartnerID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "UC_Partner";
            this.Size = new System.Drawing.Size(830, 600);
            this.Load += new System.EventHandler(this.UC_Partner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partnerDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView partnerDGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PartnerName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtPartnerName;
        private System.Windows.Forms.TextBox txtPartnerID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UClblHomepage;
    }
}
