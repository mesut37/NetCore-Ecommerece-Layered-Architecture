using EtradeApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Business
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        Category GetById(int categoryId);
        Category GetByParentId(int parentId);
        
    }
}
