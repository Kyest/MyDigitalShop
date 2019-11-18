using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLLogin
    {
        public BLLogin()
        { }
        public UserModel CheckUser(String UserName, String Password, out bool status)
        {
            //base64 pass
            var EncryptedPassB = System.Text.Encoding.UTF8.GetBytes(Password);
            var EncryptedPass = System.Convert.ToBase64String(EncryptedPassB);

            UserModel user = new UserModel();
            status = false;
            DALogin da = new DALogin();
            da.CheckUser(UserName);
            DataTable tableUsers = da.CheckUser(UserName);
           
            if (tableUsers.Rows.Count == 0)
                    status = false;

                else
                {
                    for (int i = 0; i < tableUsers.Rows.Count; i++)
                    {
                        if (EncryptedPass == tableUsers.Rows[i]["UserPassword"].ToString())
                        {
                            status = true;
                            user.UserId = Convert.ToInt32(tableUsers.Rows[i]["UserId"]);  
                            user.UserName = tableUsers.Rows[i]["UserName"].ToString();     
                            user.UserPassword = tableUsers.Rows[i]["UserPassword"].ToString();
                            user.LastLogin = DateTime.Now;
                            }
                    }
                }
                return user;
            }
        }
    }

