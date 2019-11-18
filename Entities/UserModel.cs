using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserModel
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String UserPassword { get; set; }
        public DateTime LastLogin { get; set; }

        public UserModel()
        {

        }
    }
}
