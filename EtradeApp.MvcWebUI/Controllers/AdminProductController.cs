using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EtradeApp.Business;
using EtradeApp.Business.Abstract;
using EtradeApp.Entities.Concrete;
using EtradeApp.MvcWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtradeApp.MvcWebUI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminProductController : Controller
    {
        private IProductService _productService;
        private IPhotoService _photoService;
        private ICategoryService _categoryService;
        private readonly IHostingEnvironment _env;
        public List<Category> categoryList = new List<Category>();

        public AdminProductController(IProductService productService, ICategoryService categoryService, IPhotoService photoService, IHostingEnvironment env)
        {
            _productService = productService;
            _categoryService = categoryService;
            _photoService = photoService;
            _env = env;
        }
        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetProductandCategories()
            };

            return View(productListViewModel);
        }

        public ActionResult Add()
        {
            foreach (var item in _categoryService.GetAll().Where(c => int.Parse(c.ParentId) == 0))
            {
                categoryList.Add(item);
                GetSubCategory(item.CategoryName, item.CategoryId);
            }

            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = categoryList
            };

            return View(model);
        }

        public void GetSubCategory(string categoryName, int categoryId)
        {
            foreach (var item2 in _categoryService.GetAll().Where(c => int.Parse(c.ParentId) == categoryId))
            {
                item2.CategoryName = categoryName + " > " + item2.CategoryName;
                categoryList.Add(item2);
                GetSubCategory(item2.CategoryName, item2.CategoryId);
            }
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                //System.Threading.Thread.Sleep(3000);
                TempData.Add("message", "Ürün başarılı bir şekilde eklendi");
            }

            return RedirectToAction("Add");
        }

        public ActionResult Update(int productId)
        {

            foreach (var item in _categoryService.GetAll().Where(c => int.Parse(c.ParentId) == 0))
            {
                categoryList.Add(item);
                GetSubCategory(item.CategoryName, item.CategoryId);
            }
          
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = categoryList,
                Photos = _photoService.GetPhotosofProduct(productId)

            };
            return View(model);

        }


        [HttpPost]
        public ActionResult Update([FromForm]ProductUpdateViewModel productUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                if (productUpdateViewModel.File != null)
                {
                    AddPhoto(productUpdateViewModel.Product.ProductId, productUpdateViewModel.File);
                }

               _productService.Update(productUpdateViewModel.Product);
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            return RedirectToAction("Index");
        }

        
        public void AddPhoto(int productId, List<IFormFile> file)
        {
            string fullPath = Path.Combine(_env.WebRootPath, "Uploads/Products");
            foreach (var formFile in file)
            {
                string fileNameAdd, extension, fileName;
                if (formFile.Length > 0)
                {
                    fileNameAdd = Guid.NewGuid().ToString();
                    extension = Path.GetExtension(formFile.FileName);
                    fileName = fileNameAdd + extension;
                    using (var stream = new FileStream(Path.Combine(fullPath, fileName), FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }

                    var photo = new Photo()
                    {
                        PhotoUrl = fileName,
                        ProductId = productId,
                        Sequance = 0
                    };

                    _photoService.AddPhoto(photo);
                }


            }

        }

        public ActionResult PhotoDelete(int id)
        {
            _photoService.Delete(id);

            return Json(new { result = 1, message = "Başarılı." });
        }

    }

}
