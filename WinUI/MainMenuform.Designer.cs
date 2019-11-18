namespace WinUI
{
    partial class MainMenuform
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
            this.BtnClienti = new System.Windows.Forms.Button();
            this.BtnFacturi = new System.Windows.Forms.Button();
            this.BtnArticol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClienti
            // 
            this.BtnClienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClienti.Location = new System.Drawing.Point(149, 21);
            this.BtnClienti.Name = "BtnClienti";
            this.BtnClienti.Size = new System.Drawing.Size(93, 38);
            this.BtnClienti.TabIndex = 2;
            this.BtnClienti.Text = "Clients";
            this.BtnClienti.UseVisualStyleBackColor = true;
            this.BtnClienti.Click += new System.EventHandler(this.BtnClienti_Click);
            // 
            // BtnFacturi
            // 
            this.BtnFacturi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturi.Location = new System.Drawing.Point(149, 93);
            this.BtnFacturi.Name = "BtnFacturi";
            this.BtnFacturi.Size = new System.Drawing.Size(93, 46);
            this.BtnFacturi.TabIndex = 5;
            this.BtnFacturi.Text = "Invoices";
            this.BtnFacturi.UseVisualStyleBackColor = true;
            this.BtnFacturi.Click += new System.EventHandler(this.BtnFacturi_Click);
            // 
            // BtnArticol
            // 
            this.BtnArticol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArticol.Location = new System.Drawing.Point(149, 176);
            this.BtnArticol.Name = "BtnArticol";
            this.BtnArticol.Size = new System.Drawing.Size(93, 39);
            this.BtnArticol.TabIndex = 7;
            this.BtnArticol.Text = "Item";
            this.BtnArticol.UseVisualStyleBackColor = true;
            this.BtnArticol.Click += new System.EventHandler(this.BtnArticol_Click);
            // 
            // MainMenuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.BtnArticol);
            this.Controls.Add(this.BtnFacturi);
            this.Controls.Add(this.BtnClienti);
            this.Name = "MainMenuform";
            this.Text = "Meniu Principal";
            this.Load += new System.EventHandler(this.MainMenuform_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnClienti;
        private System.Windows.Forms.Button BtnFacturi;
        private System.Windows.Forms.Button BtnArticol;
    }
}