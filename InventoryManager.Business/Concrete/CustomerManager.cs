using System.Collections.Generic;
using InventoryManager.Business.Abstract;
using InventoryManager.DataAccess.Abstract;
using InventoryManager.Entities.Concrete;

namespace InventoryManager.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetCustomerListWithJob()
        {
            return _customerDal.GetCustomerListWithJob();
        }
    }
}