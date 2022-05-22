using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class EFCustomerDal
    {
        DbCon DbCon;
        public EFCustomerDal()
        {
            DbCon = new DbCon();
        }

        public List<Customer> GetCustomers()
        {
            return DbCon.Customers.ToList();
        }

        public Customer GetCustomer(int id)
        {
            return DbCon.Customers.Find(id);
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = DbCon.Customers.Find(id);
            DbCon.Remove(customer);
            DbCon.SaveChanges();
        }
    }
}
