using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class ProductDetailDal
    {
        DbCon Db;
        public ProductDetailDal()
        {
            Db = new DbCon();
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            var result = (from x in Db.Products
                          join y in Db.Categories
                          on x.CategoryID equals y.CategoryID
                          select new ProductDetailDto()
                          {
                              ProductID = x.ProductID,
                              ProductName = x.ProductName,
                              UnitPrice = x.UnitPrice,
                              CategoryName = y.CategoryName
                          }).ToList();


            return result;
        }
    }
}
