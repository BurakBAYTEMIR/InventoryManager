using InventoryManager.Entities.Concrete;
using System.Collections.Generic;

namespace InventoryManager.DataAccess.Abstract
{
    public interface ICustomerDal : IGenericDal<Customer>
    {
        List<Customer> GetCustomerListWithJob();
    }
}