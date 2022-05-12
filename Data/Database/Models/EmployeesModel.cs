using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANode.Data.Database.Models;

namespace ANode
{
    public partial class EmployeesModel
    {
        public int employee_id { get; set; }
        public string employee_fio { get; set; }
        public string employee_birthdate { get; set; }
        public string employee_address { get; set; }
        public string employee_phone { get; set; }
        public string employee_work_experience { get; set; }
    }
}
