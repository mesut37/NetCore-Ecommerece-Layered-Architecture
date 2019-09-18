using EtradeApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.Validation
{
    public class CategoryValidator:AbstractValidator<Category>
    {

        public CategoryValidator()
        {
            RuleFor(f => f.CategoryName).NotEmpty().WithMessage("Kategori Adı boş geçilemez !");
            RuleFor(f => f.ParentId).NotEmpty().WithMessage("Ebeveyn Kategori boş geçilemez !");
        }
    }
}
