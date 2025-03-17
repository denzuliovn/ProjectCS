using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                using var db = new BusinessObject.MyDBContext();
                listProducts = db.Products.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProducts;
        }

        public static void SaveProduct(Product p)
        {
            try
            {
                using var db = new BusinessObject.MyDBContext();
                db.Products.Add(p); // thêm vào collection
                db.SaveChanges(); // cập nhật CSDL
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static void UpdateProduct(Product p)
        {
            try
            {
                using var db = new BusinessObject.MyDBContext();
                db.Entry<Product>(p).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteProduct(Product p)
        {
            try
            {
                using var db = new BusinessObject.MyDBContext();
                var p1 = db.Products.SingleOrDefault(c => c.ProductID == p.ProductID);
                db.Products.Remove(p1);


                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Product? GetProductById(int id)
        {
            Product? product = null;
            try
            {
                using (var context = new BusinessObject.MyDBContext())
                {
                    product = context.Products
                        .Include(f => f.Category)
                        .AsNoTracking()
                        .SingleOrDefault(m => m.ProductID == id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            return product;
        }


    }
}
