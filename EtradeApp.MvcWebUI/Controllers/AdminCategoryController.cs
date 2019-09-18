using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EtradeApp.Business;
using EtradeApp.Entities.Concrete;
using EtradeApp.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EtradeApp.MvcWebUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private IMapper _mapper;
        public List<Category> categoryList = new List<Category>();

        public AdminCategoryController(IProductService productService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public IActionResult Add()
        {

            foreach (var item in _categoryService.GetAll().Where(c=> c.ParentId=="0"))
            {
                categoryList.Add(item);
                GetSubCategory(item.CategoryName,item.CategoryId);
            }

            var model = new CategoryAddViewModel
            {
                Category = new Category(),
                Categories=categoryList
            };
            return View(model);
        }

        public void GetSubCategory(string categoryName, int categoryId)
        {
            foreach (var item2 in _categoryService.GetAll().Where(c=> int.Parse(c.ParentId)==categoryId))
            {
                item2.CategoryName = categoryName + " > " + item2.CategoryName;
                categoryList.Add(item2);
                GetSubCategory(item2.CategoryName, item2.CategoryId);
            }
        }

        [HttpPost]
        public ActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(category);
                TempData.Add("message", "Kategori başarılı bir şekilde eklendi");
            }

            return RedirectToAction("Add");
        }

        public ActionResult Index()
        {
            var model = new CategoryListViewModel
            {
                categories = _categoryService.GetAll()
            };
            return View(model);
        }


        public ActionResult Update(int categoryId)
        {

            foreach (var item in _categoryService.GetAll().Where(c => int.Parse(c.ParentId) == 0))
            {
                categoryList.Add(item);
                GetSubCategory(item.CategoryName, item.CategoryId);
            }

            var model = new CategoryUpdateViewModel {
                Category = _categoryService.GetById(categoryId),
                Categories= categoryList
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(category);
               
            }
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int categoryId)
        {
            _categoryService.Delete(categoryId);
            return RedirectToAction("Index");
        }

    }
}