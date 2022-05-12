using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ANode.Data.Database.Models;

namespace ANode.Data.Database
{
    internal class DatabaseContext : DbContext
    {
        public DatabaseContext(): base("MainConnectionToDatabase")
        {

        }
        public DbSet<ClientsModel> Clients { get; set; }
        public DbSet<EmployeesModel> Employees { get; set; }
    }
}
