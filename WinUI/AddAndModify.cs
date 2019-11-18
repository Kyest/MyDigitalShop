using BusinessLogic;
using DataAccess;
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
    public partial class AddAndModify : Form
    {
        public int ClientId { get; set; }
        public AddAndModify()
        {
            InitializeComponent();
        }

        public void AfiseazaClient()
        {
            BlClient blClient = new BlClient();
            var blclient = blClient.FindClientById(ClientId);  //are clientul cu toate datele.
            txtName.Text = blclient.ClientName;
            txtSurname.Text = blclient.ClientSurname;
            txtClientCode.Text = blclient.ClientCode.ToString();
            txtEmail.Text = blclient.Email;
            txtPhoneNo.Text = blclient.PhoneNo.ToString();
        }

      
        

        private void BtnModify_Click(object sender, EventArgs e)
        {
            BlClient modificaClient = new BlClient();
            var result = modificaClient.SalveazaClienti(txtName.Text, ClientId, txtSurname.Text, txtClientCode.Text, txtPhoneNo.Text, txtEmail.Text);

            if (result)
            {
                MessageBox.Show("Ai reusit! ");
            }
            else MessageBox.Show(" Ceva nu e in regula, Clientul nu a fost modificat");

            ClientForm clientformC = new ClientForm();
            clientformC.Show();
            this.Hide();
            clientformC.FormClosed += ClientForm_FormClosed;
        }

        private void BtnDelete_Click(object sender, EventArgs e)  //sa mut Delete-ul langa gridview
        {
            
                DAClient daclients = new DAClient();
                daclients.DeleteClients(ClientId);

                MessageBox.Show("Clientul a fost sters");

                ClientForm clientformC = new ClientForm();
                clientformC.Show();
                this.Hide();
                clientformC.FormClosed += ClientForm_FormClosed;

            

        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        
        
        //  FILTRU
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void AddAndModify_Load(object sender, EventArgs e)
        {

        }


        //ADRESA : 
        private void LblAddress_Click(object sender, EventArgs e)
        {   
            BlClient blClient = new BlClient();
            DaClientAddress AddressList = new DaClientAddress();
            DataTable dt = new DataTable();
            dt = AddressList.dataTableCA(ClientId);
            GridViewAddresss.DataSource = dt;
            GridViewAddresss.Columns["ClientAddressId"].Visible = false;
            GridViewAddresss.Columns["ClientId"].Visible = false;
        }

        private void LblAddAddress_Click(object sender, EventArgs e)
        {
            ClientAddressForm clientaddress = new ClientAddressForm(this.ClientId);
            clientaddress.Show();
            this.Hide();
            clientaddress.FormClosed += ClientForm_FormClosed;
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            ClientForm clientformA = new ClientForm();
            clientformA.Show();
            this.Hide();
            clientformA.FormClosed += ClientForm_FormClosed;
        }

        private void GridViewAddresss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Sterge adresa
        private void BtnDeleteAddress_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in GridViewAddresss.SelectedRows)
            {
                DaClientAddress daclientsaddress = new DaClientAddress();
                int i = Convert.ToInt32(GridViewAddresss.SelectedRows[0].Cells[0].Value);

                //bool status = false;
                //status = btnDelete.Delete

                daclientsaddress.DeleteClientAddress(i);
               
                GridViewAddresss.Rows.RemoveAt(GridViewAddresss.SelectedRows[0].Index);
                GridViewAddresss.Refresh();
                GridViewAddresss.Columns["ClientAddressId"].Visible = false;
                GridViewAddresss.Columns["ClientId"].Visible = false;


            }


            //DaClientAddress daclientsaddress = new DaClientAddress();
            //daclientsaddress.DeleteClientAddress(ClientId);    //DeleteClients(ClientId);     ClientId?

            //MessageBox.Show("Aceasta adresa a fost stearsa");

            ClientForm clientformC = new ClientForm();
            clientformC.Show();
            this.Hide();
            clientformC.FormClosed += ClientForm_FormClosed;
        }
    }
}
