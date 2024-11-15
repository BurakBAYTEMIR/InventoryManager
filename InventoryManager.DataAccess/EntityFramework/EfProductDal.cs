using InventoryManager.DataAccess.Abstract;
using InventoryManager.DataAccess.Repositories;
using InventoryManager.Entities.Concrete;

namespace InventoryManager.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {

    }
}