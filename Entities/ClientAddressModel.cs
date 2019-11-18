using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientAddressModel
    {
        
        public string AddressName { get; set; }

        public int ClientId { get; set; }  //adaugat ClientId
        public string CountyName { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }
       
        public string StreetNo { get; set; }

        public int ClientAddressId { get; set; }

}
}
