using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseCore.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Color Color { get; set; }
        public Guid ColorId { get; set; }

        public double price { get; set; }
        public bool Instock { get; set; }

        public Supplier Supplier { get; set; }
        public Guid SupplierId { get; set; }
        public IEnumerable<ProductShipmentJunction> ProductShipments { get; set; }
    }
}
