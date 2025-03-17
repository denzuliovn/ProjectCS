using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessObject
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            var listCategories = new List<Category>();
            // kiem soat loi trong qua trinh minh xu ly
            try
            {
                
                using var db = new MyDBContext(); // tao doi tuong ket noi csdl 
                listCategories = db.Categories.ToList(); // lay danh sach ra
            }
            catch (Exception e)
            {
                // bat loi thong qua
                throw new Exception(e.Message);
            }
            return listCategories;
        }
    }


}
