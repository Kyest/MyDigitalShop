using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class MainMenuform : Form
    {
        public MainMenuform()
        {
            InitializeComponent();
        }


        private void LlbClienti_Click(object sender, EventArgs e)
        {
            
}


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainMenuform_Load(object sender, EventArgs e)
        {

        }

        private void LlbFacturi_Click(object sender, EventArgs e)
        {

        }

        private void LblArticol_Click(object sender, EventArgs e)
        {

        }

        private void BtnClienti_Click(object sender, EventArgs e)

        {
            ClientForm clientformA = new ClientForm();
            clientformA.Show();
            this.Hide();
            clientformA.FormClosed += ClientForm_FormClosed;

        }

      

        private void BtnArticol_Click(object sender, EventArgs e)
        {

        }

        private void BtnFacturi_Click(object sender, EventArgs e)
        {
            
        }
        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
