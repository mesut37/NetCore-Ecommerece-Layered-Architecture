using EtradeApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EtradeApp.Entities.Concrete
{
    public class Photo : IEntity
    {
        public int PhotoId { get; set; }
        public int ProductId { get; set; }
        public string PhotoUrl { get; set; }
        public int Sequance { get; set; }

        public Product Product { get; set; }
    }
}
