using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoaderTraker
{
    public class TicketData
    {
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public string Client { get; set; }
        public string Username { get; set; }
        public List<string> Products { get; set; }
    }
}
