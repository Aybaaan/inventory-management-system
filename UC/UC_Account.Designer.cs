
namespace InventoryMngmt.UC
{
    partial class UC_Account
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.userBtnAdd = new System.Windows.Forms.Button();
            this.userTxtUsername = new System.Windows.Forms.TextBox();
            this.userTxtFullname = new System.Windows.Forms.TextBox();
            this.userTxtPassword = new System.Windows.Forms.TextBox();
            this.userTxtContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userBtnEdit = new System.Windows.Forms.Button();
            this.userBtnDelete = new System.Windows.Forms.Button();
            this.userDGrid = new System.Windows.Forms.DataGridView();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet = new InventoryMngmt.InventoryDBDataSet();
            this.inventoryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new InventoryMngmt.InventoryDBDataSetTableAdapters.UserTableTableAdapter();
            this.tableAdapterManager = new InventoryMngmt.InventoryDBDataSetTableAdapters.TableAdapterManager();
            this.UClblHomepage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userBtnAdd
            // 
            this.userBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.userBtnAdd.FlatAppearance.BorderSize = 0;
            this.userBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtnAdd.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtnAdd.ForeColor = System.Drawing.Color.White;
            this.userBtnAdd.Location = new System.Drawing.Point(20, 332);
            this.userBtnAdd.Name = "userBtnAdd";
            this.userBtnAdd.Size = new System.Drawing.Size(75, 38);
            this.userBtnAdd.TabIndex = 7;
            this.userBtnAdd.Text = "Add";
            this.userBtnAdd.UseVisualStyleBackColor = false;
            this.userBtnAdd.Click += new System.EventHandler(this.userBtnAdd_Click);
            // 
            // userTxtUsername
            // 
            this.userTxtUsername.Location = new System.Drawing.Point(127, 113);
            this.userTxtUsername.Name = "userTxtUsername";
            this.userTxtUsername.Size = new System.Drawing.Size(203, 20);
            this.userTxtUsername.TabIndex = 8;
            this.userTxtUsername.TextChanged += new System.EventHandler(this.userTxtUsername_TextChanged);
            // 
            // userTxtFullname
            // 
            this.userTxtFullname.Location = new System.Drawing.Point(125, 168);
            this.userTxtFullname.Name = "userTxtFullname";
            this.userTxtFullname.Size = new System.Drawing.Size(205, 20);
            this.userTxtFullname.TabIndex = 9;
            // 
            // userTxtPassword
            // 
            this.userTxtPassword.Location = new System.Drawing.Point(125, 223);
            this.userTxtPassword.Name = "userTxtPassword";
            this.userTxtPassword.Size = new System.Drawing.Size(205, 20);
            this.userTxtPassword.TabIndex = 10;
            // 
            // userTxtContact
            // 
            this.userTxtContact.Location = new System.Drawing.Point(125, 272);
            this.userTxtContact.Name = "userTxtContact";
            this.userTxtContact.Size = new System.Drawing.Size(205, 20);
            this.userTxtContact.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contact No.";
            // 
            // userBtnEdit
            // 
            this.userBtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(82)))), ((int)(((byte)(186)))));
            this.userBtnEdit.FlatAppearance.BorderSize = 0;
            this.userBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtnEdit.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtnEdit.ForeColor = System.Drawing.Color.White;
            this.userBtnEdit.Location = new System.Drawing.Point(127, 332);
            this.userBtnEdit.Name = "userBtnEdit";
            this.userBtnEdit.Size = new System.Drawing.Size(75, 38);
            this.userBtnEdit.TabIndex = 15;
            this.userBtnEdit.Text = "Edit";
            this.userBtnEdit.UseVisualStyleBackColor = false;
            this.userBtnEdit.Click += new System.EventHandler(this.userBtnEdit_Click);
            // 
            // userBtnDelete
            // 
            this.userBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(52)))), ((int)(((byte)(85)))));
            this.userBtnDelete.FlatAppearance.BorderSize = 0;
            this.userBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtnDelete.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtnDelete.ForeColor = System.Drawing.Color.White;
            this.userBtnDelete.Location = new System.Drawing.Point(239, 332);
            this.userBtnDelete.Name = "userBtnDelete";
            this.userBtnDelete.Size = new System.Drawing.Size(75, 38);
            this.userBtnDelete.TabIndex = 16;
            this.userBtnDelete.Text = "Delete";
            this.userBtnDelete.UseVisualStyleBackColor = false;
            this.userBtnDelete.Click += new System.EventHandler(this.userBtnDelete_Click);
            // 
            // userDGrid
            // 
            this.userDGrid.AllowUserToResizeColumns = false;
            this.userDGrid.AllowUserToResizeRows = false;
            this.userDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDGrid.BackgroundColor = System.Drawing.Color.White;
            this.userDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userDGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userDGrid.Location = new System.Drawing.Point(345, 76);
            this.userDGrid.Name = "userDGrid";
            this.userDGrid.ReadOnly = true;
            this.userDGrid.RowHeadersVisible = false;
            this.userDGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDGrid.Size = new System.Drawing.Size(445, 377);
            this.userDGrid.TabIndex = 17;
            this.userDGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDGrid_CellContentClick);
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.inventoryDBDataSet;
            // 
            // inventoryDBDataSet
            // 
            this.inventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryDBDataSetBindingSource
            // 
            this.inventoryDBDataSetBindingSource.DataSource = this.inventoryDBDataSet;
            this.inventoryDBDataSetBindingSource.Position = 0;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = InventoryMngmt.InventoryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableTableAdapter = this.userTableTableAdapter;
            // 
            // UClblHomepage
            // 
            this.UClblHomepage.AutoSize = true;
            this.UClblHomepage.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UClblHomepage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(231)))));
            this.UClblHomepage.Location = new System.Drawing.Point(16, 12);
            this.UClblHomepage.Name = "UClblHomepage";
            this.UClblHomepage.Size = new System.Drawing.Size(213, 29);
            this.UClblHomepage.TabIndex = 116;
            this.UClblHomepage.Text = "Manage Accounts";
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UClblHomepage);
            this.Controls.Add(this.userDGrid);
            this.Controls.Add(this.userBtnDelete);
            this.Controls.Add(this.userBtnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userTxtContact);
            this.Controls.Add(this.userTxtPassword);
            this.Controls.Add(this.userTxtFullname);
            this.Controls.Add(this.userTxtUsername);
            this.Controls.Add(this.userBtnAdd);
            this.Controls.Add(this.label1);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(830, 600);
            this.Load += new System.EventHandler(this.UC_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userBtnAdd;
        private System.Windows.Forms.TextBox userTxtUsername;
        private System.Windows.Forms.TextBox userTxtFullname;
        private System.Windows.Forms.TextBox userTxtPassword;
        private System.Windows.Forms.TextBox userTxtContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button userBtnEdit;
        private System.Windows.Forms.Button userBtnDelete;
        private System.Windows.Forms.DataGridView userDGrid;
        private System.Windows.Forms.BindingSource inventoryDBDataSetBindingSource;
        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private InventoryDBDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private InventoryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label UClblHomepage;
    }
}
