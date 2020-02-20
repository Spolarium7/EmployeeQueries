using DbSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using MySql.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoshenJimenez.EmployeeQueries.DAL
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {
            
        }


    }
}
