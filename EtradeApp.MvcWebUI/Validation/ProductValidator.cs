using EtradeApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Validation
{
    public class ProductValidator: AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(f => f.ProductName).NotEmpty().WithMessage("Ürün Adı boş geçilemez !");

            RuleFor(f => f.CategoryId).NotEmpty().WithMessage("Kategori boş geçilemez !");

            RuleFor(f => f.UnitPrice).NotEmpty().WithMessage("Fiyat boş geçilemez !");
        }
    }
}
