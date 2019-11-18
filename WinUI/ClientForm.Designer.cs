namespace WinUI
{
    partial class ClientForm
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
            this.btnShowClients = new System.Windows.Forms.Button();
            this.GridViewClients = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblModifyOrDeleteOnAClient = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowClients
            // 
            this.btnShowClients.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnShowClients.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnShowClients.Location = new System.Drawing.Point(0, 12);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(97, 24);
            this.btnShowClients.TabIndex = 7;
            this.btnShowClients.Text = "Show Clients";
            this.btnShowClients.UseVisualStyleBackColor = false;
            this.btnShowClients.Click += new System.EventHandler(this.BtnShowClients_Click);
            // 
            // GridViewClients
            // 
            this.GridViewClients.AllowUserToDeleteRows = false;
            this.GridViewClients.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewClients.Location = new System.Drawing.Point(0, 42);
            this.GridViewClients.Name = "GridViewClients";
            this.GridViewClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.GridViewClients.Size = new System.Drawing.Size(672, 219);
            this.GridViewClients.TabIndex = 6;
            this.GridViewClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewClients_CellClick);
            this.GridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.GridViewClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewClients_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(103, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Client";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblModifyOrDeleteOnAClient
            // 
            this.lblModifyOrDeleteOnAClient.AutoSize = true;
            this.lblModifyOrDeleteOnAClient.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyOrDeleteOnAClient.Location = new System.Drawing.Point(12, 264);
            this.lblModifyOrDeleteOnAClient.Name = "lblModifyOrDeleteOnAClient";
            this.lblModifyOrDeleteOnAClient.Size = new System.Drawing.Size(262, 16);
            this.lblModifyOrDeleteOnAClient.TabIndex = 12;
            this.lblModifyOrDeleteOnAClient.Text = "Double-Click on a Client for Modify and Address";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSearch.Location = new System.Drawing.Point(577, 264);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 20);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.LblSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(625, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "by Client Code";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(743, 263);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 20);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1132, 447);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblModifyOrDeleteOnAClient);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShowClients);
            this.Controls.Add(this.GridViewClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "ClientsForm";
            this.Load += new System.EventHandler(this.ClientsFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowClients;
        private System.Windows.Forms.DataGridView GridViewClients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblModifyOrDeleteOnAClient;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
    }
}