using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAClient
    {
        private SqlConnection connection;
        public DAClient()
        {
            connection = new SqlConnection(Properties.Resources.ConnectionString);            
        }
        public DataTable ListaSearch()
        {
            DataTable dataTableClient = new DataTable();

            try
            {
                 connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email from TClient";
                
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTableClient);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTableClient;

        }
        public void AddClients(string ClientName, string ClientSurname, string ClientCode, string PhoneNo, string Email)
        {
            try
            {
                 connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "declare @ClientId int exec GetNextId 0,'TClient',@ClientId out, 0,1 " +
                    "INSERT INTO TClient(ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email) " +
                    "Values (@ClientId, @ClientName, @ClientSurname, @ClientCode, @PhoneNo, @Email) ";

                command.Parameters.AddWithValue("@ClientName", ClientName);
               
                command.Parameters.AddWithValue("@ClientSurname", ClientSurname);
                command.Parameters.AddWithValue("ClientCode", ClientCode);
                command.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                command.Parameters.AddWithValue("@Email", Email);
                command.ExecuteNonQuery();


                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
          //  return true;

        }
        public bool DeleteClients(int ClientId)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE FROM TClient where ClientId = @ClientId";
                  
                    
                command.Parameters.AddWithValue("@ClientId", ClientId);
                
                int aufostmodificari = command.ExecuteNonQuery();

                connection.Close(); //aici se executa

                if (aufostmodificari > 0)
                {
                    return true;
                }
                else
                        return false; //iese din metoda
                   

                


               // connection.Close(); // nu se mai executa
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
             // return false; //nu se mai executa, iese din metoda

        }

       

        public bool ModifyClients(string ClientName, int ClientId, string ClientSurname, string ClientCode, string PhoneNo, string Email)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Update TClient " +
                    "SET ClientName = @ClientName, ClientSurname = @ClientSurname, ClientCode = @ClientCode, PhoneNo = @PhoneNo, Email = @Email " +
                    "where ClientId = @ClientId ";

                command.Parameters.AddWithValue("@ClientName", ClientName);
                command.Parameters.AddWithValue("@ClientId", ClientId);
                command.Parameters.AddWithValue("@ClientSurname", ClientSurname);
                command.Parameters.AddWithValue("ClientCode", ClientCode);
                command.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                command.Parameters.AddWithValue("@Email", Email);
                int clientmodificat = command.ExecuteNonQuery();

                if (clientmodificat > 0)
                {
                    return true;
                }
                else
                    return false;



            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
       

        //FILTRU
        public DataTable ListaSearchById(string ClientCode)
        {
            DataTable dataTableClient = new DataTable();

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email from TClient " +
                    "where ClientCode like '%' + @ClientCode + '%' "; //where ClientId = @ClientId and 


                command.Parameters.AddWithValue("@ClientCode", ClientCode);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTableClient);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTableClient;

        }


    }



    }

