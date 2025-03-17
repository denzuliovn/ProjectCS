using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Project
{
    class Category
    {
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public Category(string categoryId, string categoryName)
        {
            CategoryID = categoryId;
            CategoryName = categoryName;
        }


    }
}
