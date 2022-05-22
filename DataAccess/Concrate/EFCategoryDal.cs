using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class EFCategoryDal
    {
        DbCon DbCon;
        public EFCategoryDal()
        {
            DbCon = new DbCon();
        }

        public List<Product> GetProduct()
        {
            return DbCon.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return DbCon.Products.Find(id);
        }

        public void deleteProduct(int id)
        {
            Product product = DbCon.Products.Find(id);
            DbCon.Products.Remove(product);
            DbCon.SaveChanges();
        }
    }
}
