using InventoryManager.DataAccess.Abstract;
using InventoryManager.Entities.Concrete;
using System.Collections.Generic;

namespace InventoryManager.Business.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
        List<Customer> TGetCustomerListWithJob();
    }
}