using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DataAccess.DataObjects
{
    public class CategoryInfo
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public String CategoryType { get; set; }
    }
}
