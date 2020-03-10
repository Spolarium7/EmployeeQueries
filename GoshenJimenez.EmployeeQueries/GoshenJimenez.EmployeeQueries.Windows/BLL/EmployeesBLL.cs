using GoshenJimenez.EmployeeQueries.Windows.DAL;
using GoshenJimenez.EmployeeQueries.Windows.Infrastructure;
using GoshenJimenez.EmployeeQueries.Windows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoshenJimenez.EmployeeQueries.Windows.BLL
{
    public static class EmployeesBLL
    {
        public static Page<Employee> GetEmployees(long pageIndex = 1, long pageSize = 3)
        {
            var result = new Page<Employee>();

            DataAccess dataAccess = new DataAccess();

            var query = dataAccess.Employees.AsQueryable();
            result.PageIndex = pageIndex;
            result.PageSize = pageSize;
            result.ItemCount = query.Count();

            result.PageCount = result.ItemCount / result.PageSize;

            var mod = result.ItemCount % result.PageSize;
            if(mod > 0)
            {
                result.PageCount = result.PageCount + 1;
            }

            var skip = (int)((result.PageIndex - 1) * result.PageSize);

            result.Items = dataAccess.Employees
                                .OrderBy(e => e.Id)
                                .Skip(skip)
                                .Take((int)result.PageSize)
                                .ToList();

            return result;
        }
    }
}
