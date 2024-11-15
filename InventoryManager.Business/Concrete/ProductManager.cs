using System.Collections.Generic;
using InventoryManager.Business.Abstract;
using InventoryManager.DataAccess.Abstract;
using InventoryManager.Entities.Concrete;

namespace InventoryManager.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }
    }
}