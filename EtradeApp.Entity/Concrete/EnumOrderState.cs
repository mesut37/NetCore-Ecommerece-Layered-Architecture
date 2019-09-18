using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EtradeApp.Entities.Concrete
{
    public enum EnumOrderState
    {
        [Display(Name = "Hazırlanıyor")]
        Waiting,
        [Display(Name = "Kargoya Verildi")]
        Shipped ,
        [Display(Name = "Ulaştı")]
        Completed,
        [Display(Name = "İptal Edildi")]
        Canceled
    }
}
