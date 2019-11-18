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
    public partial class ClientForm : Form
    {
        public int ClientId { get; set; }
        public ClientForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientsFormcs_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdaugaClienti_Click(object sender, EventArgs e)
        {

        }

        private void LblAdaugaClienti_Click(object sender, EventArgs e)
        {

        }

        private void BtnShowClients_Click(object sender, EventArgs e)
        {
            BusinessLogic.BlClient blClient = new BusinessLogic.BlClient();
            DAClient clientList = new DAClient();
            GridViewClients.DataSource = clientList.ListaSearch();
            GridViewClients.Columns["ClientId"].Visible = false;


            //List<ClientModel> ListClientA = new List<ClientModel>();
            //ListClientA = blClient.clientModels();


            //   GridViewClients.Columns["ClientName"].HeaderText = "Nume CLient";

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddClientForm clientformB = new AddClientForm();
            clientformB.Show();
            this.Hide();
            clientformB.FormClosed += ClientForm_FormClosed;
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void GridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var clientidentifier = GridViewClients.Rows[e.RowIndex].Cells[0].Value.ToString(); //selecteaza datagridview, rand, coloana ptr clientid


            AddAndModify clientformD = new AddAndModify();//delete and modify defapt
            clientformD.ClientId = int.Parse(clientidentifier);
            clientformD.AfiseazaClient();
            clientformD.Show();
            this.Hide();
            clientformD.FormClosed += ClientForm_FormClosed;




        }

        private void saas(object sender, EventArgs e)
        {

        }

        //FILTRU
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //BlClient blClient = new BlClient();
            //DAClient cautaList = new DAClient();
            //GridViewClients.DataSource = cautaList.ListaSearchById(txtSearch.Text);

        }

       
        //FILTRU
        private void LblSearch_Click(object sender, EventArgs e)
        {
            BlClient blClient = new BlClient();
            DAClient cautaList = new DAClient();
            GridViewClients.DataSource = cautaList.ListaSearchById(txtSearch.Text);  

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DAClient daclients = new DAClient();
            daclients.DeleteClients(ClientId);

            MessageBox.Show("Clientul a fost sters");

            ClientForm clientformC = new ClientForm();
            clientformC.Show();
            this.Hide();
            clientformC.FormClosed += ClientForm_FormClosed;

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}

//BusinessLogic.BlClient blClient = new BusinessLogic.BlClient();
//DAClient clientList = new DAClient();
//GridViewClients.DataSource = clientList.ListaSearch();