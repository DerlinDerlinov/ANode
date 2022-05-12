using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ANode.AData.Modules.TableModules
{
    public partial class Services
    {
        public int service_id { get; set; }
        public string service_title { get; set; }
        public string service_desc { get; set; }
        public Nullable<float> service_cost { get; set; }

        public virtual EmployeesModel Employees { get; set; }
    }
}
