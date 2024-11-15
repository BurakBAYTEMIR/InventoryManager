using System.Collections.Generic;
using InventoryManager.Business.Abstract;
using InventoryManager.DataAccess.Abstract;
using InventoryManager.Entities.Concrete;

namespace InventoryManager.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TInsert(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }
    }
}