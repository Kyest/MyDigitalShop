namespace WinUI
{
    partial class ClientAddressForm
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
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblCountyName = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblStreetNo = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtStreetNo = new System.Windows.Forms.TextBox();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.btnSaveAddress = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(101, 64);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(55, 13);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City Name";
            // 
            // lblCountyName
            // 
            this.lblCountyName.AutoSize = true;
            this.lblCountyName.Location = new System.Drawing.Point(101, 125);
            this.lblCountyName.Name = "lblCountyName";
            this.lblCountyName.Size = new System.Drawing.Size(71, 13);
            this.lblCountyName.TabIndex = 1;
            this.lblCountyName.Text = "County Name";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Location = new System.Drawing.Point(101, 189);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(66, 13);
            this.lblStreetName.TabIndex = 2;
            this.lblStreetName.Text = "Street Name";
            // 
            // lblStreetNo
            // 
            this.lblStreetNo.AutoSize = true;
            this.lblStreetNo.Location = new System.Drawing.Point(101, 253);
            this.lblStreetNo.Name = "lblStreetNo";
            this.lblStreetNo.Size = new System.Drawing.Size(75, 13);
            this.lblStreetNo.TabIndex = 3;
            this.lblStreetNo.Text = "Street Number";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(200, 57);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(120, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(200, 125);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(120, 20);
            this.txtCounty.TabIndex = 7;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(200, 182);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(120, 20);
            this.txtStreetName.TabIndex = 8;
            // 
            // txtStreetNo
            // 
            this.txtStreetNo.Location = new System.Drawing.Point(200, 246);
            this.txtStreetNo.Name = "txtStreetNo";
            this.txtStreetNo.Size = new System.Drawing.Size(120, 20);
            this.txtStreetNo.TabIndex = 9;
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClient.Location = new System.Drawing.Point(142, 22);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(98, 16);
            this.lblAddClient.TabIndex = 11;
            this.lblAddClient.Text = "Add Address";
            // 
            // btnSaveAddress
            // 
            this.btnSaveAddress.Location = new System.Drawing.Point(502, 313);
            this.btnSaveAddress.Name = "btnSaveAddress";
            this.btnSaveAddress.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAddress.TabIndex = 12;
            this.btnSaveAddress.Text = "Save";
            this.btnSaveAddress.UseVisualStyleBackColor = true;
            this.btnSaveAddress.Click += new System.EventHandler(this.BtnSaveAddress_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ClientAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 416);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveAddress);
            this.Controls.Add(this.lblAddClient);
            this.Controls.Add(this.txtStreetNo);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblStreetNo);
            this.Controls.Add(this.lblStreetName);
            this.Controls.Add(this.lblCountyName);
            this.Controls.Add(this.lblCityName);
            this.Name = "ClientAddressForm";
            this.Text = "ClientAddress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblCountyName;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblStreetNo;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtStreetNo;
        private System.Windows.Forms.Label lblAddClient;
        private System.Windows.Forms.Button btnSaveAddress;
        private System.Windows.Forms.Button btnBack;
    }
}