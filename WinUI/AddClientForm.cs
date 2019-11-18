using DataAccess;
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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Numele nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtClientSurname.Text))
            {
                MessageBox.Show("Numele de familie nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtClientCode.Text))
            {
                MessageBox.Show("Codul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtClientPhoneNo.Text))
            {
                MessageBox.Show("PhoneNo nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtClientEmail.Text))
            {
                MessageBox.Show("Email nu este completata", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DAClient daClient= new DAClient();
            //apelez datele(txt) din winUI, in locul parametrilor AddClients.
            daClient.AddClients(txtClientName.Text, txtClientSurname.Text, txtClientCode.Text, txtClientEmail.Text, txtClientPhoneNo.Text);

            MessageBox.Show("S-a salvat");

            ClientForm clientformC = new ClientForm();
            clientformC.Show();
            this.Hide();
            clientformC.FormClosed += ClientForm_FormClosed;





        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
