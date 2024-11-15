using InventoryManager.DataAccess.Abstract;
using InventoryManager.DataAccess.Concrete;
using InventoryManager.DataAccess.Repositories;
using InventoryManager.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManager.DataAccess.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public List<Customer> GetCustomerListWithJob()
        {
            using (var c = new Context())
            {
                return c.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}