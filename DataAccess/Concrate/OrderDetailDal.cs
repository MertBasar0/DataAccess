using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class OrderDetailDal
    {
        DbCon dbCon;
        public OrderDetailDal()
        {
            dbCon = new DbCon();
        }

        public List<OrderDetailDto> GetDetailDtos()
        {
            var result = (from x in dbCon.Orders
                          join z in dbCon.Employees
                          on x.EmployeeID equals z.EmployeeID
                          join y in dbCon.Customers
                          on x.CustomerID equals y.CustomerID
                         select new OrderDetailDto()
                         {
                             OrderID = x.OrderID,
                             FirstName = z.FirstName,
                             CompanyName = y.CompanyName,
                             OrderDate = x.OrderDate
                         }).ToList();

            return result;
        }
    }
}
