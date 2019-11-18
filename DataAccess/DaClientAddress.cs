using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DaClientAddress
    {
        private SqlConnection connection;
        public DaClientAddress()
        {
            connection = new SqlConnection(Properties.Resources.ConnectionString);
        }
        public DataTable dataTableCA(int ClientId)   // prin parametru de intrare din Client
        {
            DataTable dataTableClientAddress = new DataTable();

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select tca.ClientAddressId, tca.ClientId, tca.StreetName, tca.StreetNo, tc.CityName, tco.CountyName from TClientAddress tca " +
                    "join TCity tc on tc.CityId = tca.CityId " +
                    "join TCounty tco on tco.CountyId = tca.CountyId " +
                    " where ClientId = @ClientId";

                command.Parameters.AddWithValue("@ClientId", ClientId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTableClientAddress);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataTableClientAddress;
        }

        public void AddClientAddress(int ClientId, string CityName, string CountyName, string Street, string StreetNo)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();  //findaddress
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "declare @ClientAddressId int exec GetNextId 0,'TClientAddress',@ClientAddressId out, 0,1 " +
                    "INSERT INTO TClientAddress(ClientAddressId, ClientId, CityId, CountyId, StreetName, StreetNo) " +
                    "SELECT @ClientAddressId, @ClientId, (SELECT CityId from TCity where CityName Like @CityName), " +
                    "(SELECT CountyId from TCounty where CountyName Like @CountyName), " +
                    "@StreetName, @StreetNo";

                command.Parameters.AddWithValue("@ClientId", ClientId);
                command.Parameters.AddWithValue("@CityName", CityName);
                command.Parameters.AddWithValue("@CountyName", CountyName);
                command.Parameters.AddWithValue("@StreetName", Street);
                command.Parameters.AddWithValue("@StreetNo", StreetNo);
                command.ExecuteNonQuery();


                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteClientAddress(int id)
        {
            
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "DELETE tca FROM TClientAddress tca where tca.ClientAddressId = @ClientAddressId ";


                command.Parameters.AddWithValue("@ClientAddressId", id);

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
        }
    }
}
