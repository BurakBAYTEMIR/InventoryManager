using InventoryManager.DataAccess.Abstract;
using InventoryManager.DataAccess.Repositories;
using InventoryManager.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.DataAccess.EntityFramework
{
    public class EfJobDal : GenericRepository<Job>, IJobDal
    {
    }
}
