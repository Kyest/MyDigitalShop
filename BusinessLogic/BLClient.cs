using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BlClient
    {


        public ClientModel FindClientById(int ClientIdcareVineDinUI)
        {
            DAClient daClient = new DAClient();
            var ListaClients = daClient.ListaSearch(); //aici sunt toti clientii;


            for (int i = 0; i < ListaClients.Rows.Count; i++)
            {
                if (ListaClients.Rows[i]["ClientId"].ToString() == ClientIdcareVineDinUI.ToString()) //verifica daca ClientId din DA == ClientId din UI, verifica daca randul care contine ClientID are valoarea == ClientId din winUi de la dublu click
                {
                    ClientModel clientmodel = new ClientModel();
                    clientmodel.ClientCode = ListaClients.Rows[i]["ClientCode"].ToString();
                    clientmodel.ClientName = ListaClients.Rows[i]["ClientName"].ToString();
                    clientmodel.ClientSurname = ListaClients.Rows[i]["ClientSurname"].ToString();
                    clientmodel.Email = ListaClients.Rows[i]["Email"].ToString();
                    clientmodel.PhoneNo = ListaClients.Rows[i]["PhoneNo"].ToString();

                    return clientmodel;
                }
            }
            return null;
        }

       // Adrese:

        //public ClientAddressModel FindAddress(int ClientIdcareVineDinUI)
        //{
        //    DaClientAddress daClientAddress = new DaClientAddress();
        //    var ListaClientAddress = daClientAddress.dataTableCA(ClientIdcareVineDinUI); //aici sunt toti clientii;


        //    for (int i = 0; i < ListaClientAddress.Rows.Count; i++)
        //    {
        //        if (ListaClientAddress.Rows[i]["ClientId"].ToString() == ClientIdcareVineDinUI.ToString()) //verifica daca ClientId din DA == ClientId din UI, verifica daca randul care contine ClientID are valoarea == ClientId din winUi de la dublu click
        //        {
        //            ClientAddressModel clientaddress = new ClientAddressModel();
        //            clientaddress.AddressName = ListaClientAddress.Rows[i]["AdressName"].ToString();
        //            clientaddress.CityName = ListaClientAddress.Rows[i]["CityName"].ToString();
        //            clientaddress.CountyName = ListaClientAddress.Rows[i]["CountyName"].ToString();
        //            clientaddress.StreetName = ListaClientAddress.Rows[i]["StreetName"].ToString();
        //            clientaddress.StreetNo = ListaClientAddress.Rows[i]["StreetNo"].ToString();
        //            //  clientaddress.StreetNo =

        //            return clientaddress;
        //        }
        //    }
        //    return null;
        //}




        // modify :
        public bool SalveazaClienti(string ClientName, int ClientId, string ClientSurname, string ClientCode, string PhoneNo, string Email)
        {
            DAClient modificaClienti = new DAClient();
            var resultatmodificare = modificaClienti.ModifyClients(ClientName, ClientId, ClientSurname, ClientCode, PhoneNo, Email); //parametrii in ordine dupa metoda din DaClient
            return resultatmodificare;
        }
        
        //FILTRU:
        public DataTable CautaUnClient(string ClientCode)
        {
            DAClient cauta = new DAClient();
            var result = cauta.ListaSearchById(ClientCode);
            return result;
        }

        //ADRESA

        //public DataTable Adresa(int ClientId) //sters parametrii
        //{
        //    DaClientAddress adresaclient = new DaClientAddress();
        //    var rezultat = adresaclient.dataTableCA(ClientId);
        //    return rezultat;
        //}

        public void addClientAddress(int ClientId, string CityName, string CountyName, string StreetName, string StreetNo)
        {
            DaClientAddress addclientAddress = new DaClientAddress();
            
            addclientAddress.AddClientAddress(ClientId, CityName, CountyName, StreetName, StreetNo);
            
        }


    }

}



//    class BLClient
//    {
//        public ClientModel CheckClient(string ClientName, string ClientSurname,  int ClientCode, int PhoneNo, string Email, out bool status)
//        {

//            ClientModel clientmodel = new ClientModel();
//            status = false;
//            DAClient daC = new DAClient();
//            DataTable listClient = daC.CheckClient(ClientName);

//            if (dataTableClient.Rows.Count == 0)
//                status = false;

//            else
//            {
//                for (int i = 0; i < dataTableClient.Rows.Count; i++)
//                {
//                    if (ClientName == dataTableClient.Rows[i]["ClientName"].ToString())
//                    {
//                        status = true;
//                        clientmodel.ClientCode = Convert.ToInt32(dataTableClient.Rows[i]["UserId"]);
//                        clientmodel.ClientName = dataTableClient.Rows[i]["ClientName"].ToString();
//                        clientmodel.ClientSurname = dataTableClient.Rows[i]["ClientSurname"].ToString();
//                        clientmodel.Email = dataTableClient.Rows[i]["Email"].ToString();
//                        clientmodel.PhoneNo = Convert.ToInt32(dataTableClient.Rows[i]["UserId"]);
//                    }
//                }
//            }
//            return clientmodel;
//        }
//    }
//}




