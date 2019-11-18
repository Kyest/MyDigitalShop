using BusinessLogic;
using Entities;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text)) { 
                MessageBox.Show("Parola nu este completata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

            if (String.IsNullOrWhiteSpace(txtPassword.Text)){
            MessageBox.Show("Utilizatorul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            String UserName = txtUserName.Text;
            String Passwword = txtPassword.Text;
            BLLogin bl = new BLLogin();
            UserModel user = bl.CheckUser(txtUserName.Text, txtPassword.Text, out bool status);
            if(status)
            {
                MainMenuform mainMenu = new MainMenuform();
                mainMenu.Show();
                this.Hide();
                mainMenu.FormClosed += MainMenu_FormClosed;

            }

            else
                MessageBox.Show("Utilizatorul sau Parola incorecta", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblUserName_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
