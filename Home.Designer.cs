
namespace InventoryMngmt
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPartners = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDefect = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnStocks = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Transfer1 = new InventoryMngmt.UC.UC_Transfer();
            this.uC_Partner1 = new InventoryMngmt.UC.UC_Partner();
            this.uC_Monitoring1 = new InventoryMngmt.UC.UC_Monitoring();
            this.uC_Returns1 = new InventoryMngmt.UC.UC_Returns();
            this.uC_Orders1 = new InventoryMngmt.UC.UC_Orders();
            this.uC_Stocks1 = new InventoryMngmt.UC.UC_Stocks();
            this.uC_Categories1 = new InventoryMngmt.UC.UC_Categories();
            this.uC_Homepage1 = new InventoryMngmt.UC.UC_Homepage();
            this.uC_Account1 = new InventoryMngmt.UC.UC_Account();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnPartners);
            this.panel1.Controls.Add(this.btnTransfer);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDefect);
            this.panel1.Controls.Add(this.btnMonitor);
            this.panel1.Controls.Add(this.btnStocks);
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 600);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "IMS";
            // 
            // btnPartners
            // 
            this.btnPartners.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnPartners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPartners.FlatAppearance.BorderSize = 0;
            this.btnPartners.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnPartners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartners.Font = new System.Drawing.Font("Lato", 15.75F);
            this.btnPartners.ForeColor = System.Drawing.Color.White;
            this.btnPartners.Image = ((System.Drawing.Image)(resources.GetObject("btnPartners.Image")));
            this.btnPartners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartners.Location = new System.Drawing.Point(0, 348);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPartners.Size = new System.Drawing.Size(169, 38);
            this.btnPartners.TabIndex = 9;
            this.btnPartners.Text = "Partners";
            this.btnPartners.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPartners.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPartners.UseVisualStyleBackColor = false;
            this.btnPartners.Click += new System.EventHandler(this.btnPartners_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Lato", 14.75F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTransfer.Image")));
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(0, 172);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(169, 38);
            this.btnTransfer.TabIndex = 8;
            this.btnTransfer.Text = "Stock Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Lato", 15.75F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 389);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnUser.Size = new System.Drawing.Size(169, 38);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "Accounts";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Lato", 15.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 430);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLogout.Size = new System.Drawing.Size(169, 38);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnDefect
            // 
            this.btnDefect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnDefect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDefect.FlatAppearance.BorderSize = 0;
            this.btnDefect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnDefect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefect.Font = new System.Drawing.Font("Lato", 12.75F);
            this.btnDefect.ForeColor = System.Drawing.Color.White;
            this.btnDefect.Image = ((System.Drawing.Image)(resources.GetObject("btnDefect.Image")));
            this.btnDefect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefect.Location = new System.Drawing.Point(0, 302);
            this.btnDefect.Name = "btnDefect";
            this.btnDefect.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDefect.Size = new System.Drawing.Size(169, 38);
            this.btnDefect.TabIndex = 5;
            this.btnDefect.Text = "Defective Items";
            this.btnDefect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDefect.UseVisualStyleBackColor = false;
            this.btnDefect.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonitor.FlatAppearance.BorderSize = 0;
            this.btnMonitor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitor.Font = new System.Drawing.Font("Lato", 15.75F);
            this.btnMonitor.ForeColor = System.Drawing.Color.White;
            this.btnMonitor.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitor.Image")));
            this.btnMonitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitor.Location = new System.Drawing.Point(0, 259);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMonitor.Size = new System.Drawing.Size(169, 38);
            this.btnMonitor.TabIndex = 4;
            this.btnMonitor.Text = "Monitoring";
            this.btnMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnStocks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStocks.FlatAppearance.BorderSize = 0;
            this.btnStocks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStocks.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.ForeColor = System.Drawing.Color.White;
            this.btnStocks.Image = ((System.Drawing.Image)(resources.GetObject("btnStocks.Image")));
            this.btnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStocks.Location = new System.Drawing.Point(0, 84);
            this.btnStocks.Margin = new System.Windows.Forms.Padding(0);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Padding = new System.Windows.Forms.Padding(7, 0, 5, 0);
            this.btnStocks.Size = new System.Drawing.Size(169, 38);
            this.btnStocks.TabIndex = 3;
            this.btnStocks.Text = " Stocks";
            this.btnStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStocks.UseVisualStyleBackColor = false;
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Lato", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 128);
            this.btnSale.Name = "btnSale";
            this.btnSale.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSale.Size = new System.Drawing.Size(169, 38);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Stock Out";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(164)))), ((int)(((byte)(178)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Lato", 14.75F);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 216);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCategory.Size = new System.Drawing.Size(169, 38);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Classification";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_Transfer1);
            this.panel2.Controls.Add(this.uC_Partner1);
            this.panel2.Controls.Add(this.uC_Monitoring1);
            this.panel2.Controls.Add(this.uC_Returns1);
            this.panel2.Controls.Add(this.uC_Orders1);
            this.panel2.Controls.Add(this.uC_Stocks1);
            this.panel2.Controls.Add(this.uC_Categories1);
            this.panel2.Controls.Add(this.uC_Homepage1);
            this.panel2.Controls.Add(this.uC_Account1);
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 660);
            this.panel2.TabIndex = 0;
            // 
            // uC_Transfer1
            // 
            this.uC_Transfer1.BackColor = System.Drawing.Color.White;
            this.uC_Transfer1.Location = new System.Drawing.Point(2, 0);
            this.uC_Transfer1.Name = "uC_Transfer1";
            this.uC_Transfer1.Size = new System.Drawing.Size(830, 600);
            this.uC_Transfer1.TabIndex = 8;
            // 
            // uC_Partner1
            // 
            this.uC_Partner1.BackColor = System.Drawing.Color.White;
            this.uC_Partner1.Location = new System.Drawing.Point(0, 0);
            this.uC_Partner1.Name = "uC_Partner1";
            this.uC_Partner1.Size = new System.Drawing.Size(830, 600);
            this.uC_Partner1.TabIndex = 7;
            // 
            // uC_Monitoring1
            // 
            this.uC_Monitoring1.BackColor = System.Drawing.Color.White;
            this.uC_Monitoring1.Location = new System.Drawing.Point(0, 0);
            this.uC_Monitoring1.Name = "uC_Monitoring1";
            this.uC_Monitoring1.Size = new System.Drawing.Size(830, 600);
            this.uC_Monitoring1.TabIndex = 6;
            // 
            // uC_Returns1
            // 
            this.uC_Returns1.BackColor = System.Drawing.Color.White;
            this.uC_Returns1.Location = new System.Drawing.Point(0, 0);
            this.uC_Returns1.Name = "uC_Returns1";
            this.uC_Returns1.Size = new System.Drawing.Size(830, 600);
            this.uC_Returns1.TabIndex = 5;
            // 
            // uC_Orders1
            // 
            this.uC_Orders1.Location = new System.Drawing.Point(0, 0);
            this.uC_Orders1.Name = "uC_Orders1";
            this.uC_Orders1.Size = new System.Drawing.Size(830, 600);
            this.uC_Orders1.TabIndex = 4;
            // 
            // uC_Stocks1
            // 
            this.uC_Stocks1.BackColor = System.Drawing.Color.White;
            this.uC_Stocks1.Location = new System.Drawing.Point(0, 0);
            this.uC_Stocks1.Name = "uC_Stocks1";
            this.uC_Stocks1.Size = new System.Drawing.Size(830, 600);
            this.uC_Stocks1.TabIndex = 3;
            // 
            // uC_Categories1
            // 
            this.uC_Categories1.BackColor = System.Drawing.Color.White;
            this.uC_Categories1.Location = new System.Drawing.Point(0, 0);
            this.uC_Categories1.Name = "uC_Categories1";
            this.uC_Categories1.Size = new System.Drawing.Size(830, 600);
            this.uC_Categories1.TabIndex = 2;
            // 
            // uC_Homepage1
            // 
            this.uC_Homepage1.BackColor = System.Drawing.Color.White;
            this.uC_Homepage1.Location = new System.Drawing.Point(0, 0);
            this.uC_Homepage1.Name = "uC_Homepage1";
            this.uC_Homepage1.Size = new System.Drawing.Size(831, 600);
            this.uC_Homepage1.TabIndex = 1;
            // 
            // uC_Account1
            // 
            this.uC_Account1.BackColor = System.Drawing.Color.White;
            this.uC_Account1.Location = new System.Drawing.Point(0, 0);
            this.uC_Account1.Name = "uC_Account1";
            this.uC_Account1.Size = new System.Drawing.Size(880, 600);
            this.uC_Account1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "FashionBug";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDefect;
        private System.Windows.Forms.Button btnUser;
        private UC.UC_Account uC_Account1;
        private UC.UC_Homepage uC_Homepage1;
        private UC.UC_Categories uC_Categories1;
        private UC.UC_Stocks uC_Stocks1;
        private UC.UC_Orders uC_Orders1;
        private UC.UC_Returns uC_Returns1;
        private System.Windows.Forms.Button btnPartners;
        private System.Windows.Forms.Button btnTransfer;
        private UC.UC_Monitoring uC_Monitoring1;
        private UC.UC_Partner uC_Partner1;
        private UC.UC_Transfer uC_Transfer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}