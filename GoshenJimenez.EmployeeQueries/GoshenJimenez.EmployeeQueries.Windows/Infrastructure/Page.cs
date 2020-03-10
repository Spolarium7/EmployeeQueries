using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoshenJimenez.EmployeeQueries.Windows.Infrastructure
{
    public class Page<T>
    {
        public List<T> Items { get; set; }

        public long PageIndex { get; set; }

        public long PageCount { get; set; }

        public long ItemCount { get; set; }

        public long PageSize { get; set; }
    }
}
