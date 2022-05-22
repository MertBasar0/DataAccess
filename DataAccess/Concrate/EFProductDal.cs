using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class EFProductDal
    {
        DbCon DbCon;

        public EFProductDal()
        {
            DbCon = new DbCon();
        }

        public List<Product> GetProducts()
        {
            return DbCon.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return DbCon.Products.Find(id);
        }

        public void DeleteProduct(int id)
        {
            Product pr = GetProduct(id);
            DbCon.Products.Remove(pr);
            DbCon.SaveChanges();
        }

        //public List<Product> 
    }
}
