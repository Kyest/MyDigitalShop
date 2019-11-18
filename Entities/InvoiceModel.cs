using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class InvoiceModel
    {
        public int InvoiceNumber { get; set; }
        public DateTime Invoicedate { get; set; }
        public String  Partner { get; set; }
        public string PartnerAddress { get; set; }
        public string Observations { get; set; }
    }
}
