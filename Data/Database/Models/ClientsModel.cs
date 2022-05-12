using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANode.Data.Database.Models
{
    internal class ClientsModel
    {
        public int client_id { get; set; }
        public string client_fio { get; set; }
        public string client_address { get; set; }
        public string client_phone { get; set; }
        public Nullable<int> client_purchases_number { get; set; }
        public int client_level_id { get; set; }
    }
}
