using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANode.AData.Modules
{
    internal class ANodeManager
    {
        public static ANodeEntities ANodeObject;


    }
    public partial class ANodeEntities : DbContext
    {
        private static ANodeEntities _context;
        public ANodeEntities()
            : base("name=ANodeEntities")
        {
        }
        public static ANodeEntities GetContext()
        {
            if (_context == null)
                _context = new ANodeEntities();

            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    }
}
