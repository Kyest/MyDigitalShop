using BusinessLogic;
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
    public partial class ClientAddressForm : Form
    {
        public int ClientId;
        public ClientAddressForm(int ClientId)
        {
            InitializeComponent();
            AddAndModify ptrGridView = new AddAndModify();
            BlClient blClientAddress = new BlClient();


           // ptrGridView.GridViewAddresss.DataSource = blClientAddress.Adresa(ClientId);
            //ptrGridView.GridViewAddresss.Columns["ClientAddressId"].Visible = false;
            //ptrGridView.GridViewAddresss.Columns["ClientId"].Visible = false;
            this.ClientId = ClientId;

    }
        

        

        //Adrese Clienti: ClientId este in plus
        private void BtnSaveAddress_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("Orasul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(txtCounty.Text))
            {
                MessageBox.Show("Judetul nu este completat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            BlClient addAddress = new BlClient();
            addAddress.addClientAddress(this.ClientId, txtCity.Text, txtCounty.Text, txtStreetName.Text, txtStreetNo.Text);




            //BlClient daAdresa = new BlClient();
            ////apelez datele(txt) din winUI, in locul parametrilor AddClients.

            //DaClientAddress addressList = new DaClientAddress();
            //AddAndModify adaugaAdress = new AddAndModify();
            //adaugaAdress.GridViewAddresss.DataSource = addressList.AddClientAddress(ClientId, txtCity.Text, txtCounty.Text, txtStreetName.Text, null);


            //// daAdresa.AddClientAddress(ClientId, txtCity.Text, txtCounty.Text, txtStreetName.Text, StreetNo);

            ClientForm clientformAB = new ClientForm();
            clientformAB.Show();
            MessageBox.Show("Adresa a fost adaugata" );
            this.Hide();
            clientformAB.FormClosed += ClientForm_FormClosed;

        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AddAndModify goback = new AddAndModify();
            goback.Show();
            this.Hide();
            goback.FormClosed += ClientForm_FormClosed;
        }
    }
}
