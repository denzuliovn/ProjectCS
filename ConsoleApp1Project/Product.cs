using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Project
{
    class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public float UnitPrice { get; set; }
        public Category Cat { get; set; }

        public Product(string productId, string productName, int unitsInStock, float unitPrice, Category category)
        {
            ProductID = productId;
            ProductName = productName;
            UnitsInStock = unitsInStock;
            UnitPrice = unitPrice;
            Cat = category;
            category.Products.Add(this); // Thêm sản phẩm vào danh sách của Category
        }

    }
}
