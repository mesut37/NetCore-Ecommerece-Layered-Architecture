using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtradeApp.Business;
using EtradeApp.Entities.Concrete;
using EtradeApp.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EtradeApp.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {

        private IProductService _productService;
        private IPhotoService _photoService;
        private ICategoryService _categoryService;


        public HomeController(IProductService productService, ICategoryService categoryService, IPhotoService photoService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _photoService = photoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            var photos = _photoService.GetPhotosofProduct(id);
            string photoUrl = "";

            var product = _productService.GetById(id);
            var model = new ProductDetailViewModel
            {

                Product = product,
                Photos = ((photos.Count > 0) ? photos : new List<Photo>()),
                PhotoUrl = ((photos.Count > 0) ? photos.FirstOrDefault().PhotoUrl.ToString() : "noimage"),
                Categories = GetBreadCrumb(product.CategoryId)
            };
            return View(model);
        }

        public List<Category> GetBreadCrumb(int categoryId)
        {

            List<Category> categories = new List<Category>();

            var categoryAdd = _categoryService.GetById(categoryId);
            categories.Add(categoryAdd);
            int parentId = int.Parse(categoryAdd.ParentId);

            while (parentId != 0)
            {
                categoryAdd = _categoryService.GetByParentId(parentId);
                categories.Add(categoryAdd);
                parentId = int.Parse(categoryAdd.ParentId);
                categories.Reverse();
            }
            return categories;

        }

        public IActionResult Products(int categoryId, int page = 1)
        {
            int pageSize =4;

            var products = _productService.GetByCategory(categoryId);

            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling((products.Count / (double)pageSize)),
                PageSize = pageSize,
                CurrentCategory = categoryId,
                CurrentPage = page

            };

            return View(model);
        }

        public IActionResult Search(string kategori, string kelime, int page = 1)
        {

            int pageSize =4;

            var products = _productService.GetAll().Where(p=> p.ProductName.ToLower().Contains(kelime.ToLower())).ToList();

            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling((products.Count / (double)pageSize)),
                PageSize = pageSize,
                CurrentPage = page

            };

            return View(model);
        }

       

    }


}