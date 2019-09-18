using System;
using System.Collections.Generic;
using System.Text;
using EtradeApp.DataAccess.Abstract;
using EtradeApp.Entities.Concrete;

namespace EtradeApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }


        public void Delete(int categoryId)
        {
            _categoryDal.Delete(new Category { CategoryId = categoryId });
        }

        public Category GetByParentId(int parentId)
        {

            return _categoryDal.Get(c => c.CategoryId == parentId);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
