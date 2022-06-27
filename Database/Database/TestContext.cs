using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class TestContext : DbContext
    {
        public TestContext() : base("DbConnection") { }
        public DbSet<TestTable> TestTables { get; set; }
    }
}
