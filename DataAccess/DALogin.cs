using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DALogin
    {
        public DALogin()
        {

        }

        public DataTable CheckUser(String UserName)
        {
            DataTable dataTable = new DataTable();

           try
        {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
        connection.Open();

            SqlCommand command = new SqlCommand();
        command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select UserId, UserName, UserPassword from TERPUser" + " Where UserName = @UserName";

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@UserName";
            parameter.DbType = System.Data.DbType.String;
            parameter.Size = 256;
            parameter.Direction = System.Data.ParameterDirection.Input;
            parameter.Value = UserName;

            command.Parameters.Add(parameter);

            SqlDataAdapter adapter = new SqlDataAdapter();
         adapter.SelectCommand = command;
         adapter.Fill(dataTable);
                connection.Close();
            }
            catch(Exception ex)
            {
               throw ex;
            }
            return dataTable;
        }
    }
    
}
