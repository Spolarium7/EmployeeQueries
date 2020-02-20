using DbSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using MySql.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoshenJimenez.EmployeeQueries.Windows.Models;

namespace GoshenJimenez.EmployeeQueries.Windows.DAL
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {
            Database.SetInitializer(new GoshenJimenez.EmployeeQueries.Windows.DAL.DataInitializer());
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
