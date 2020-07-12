using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseCore.Models
{
    public class ProductShipmentJunction
    {
        [Key]
        public Guid Id { get; set; }
        public Product Products { get; set; }
        public Guid Product { get; set; }
        public Shipment Shipments { get; set; }
        public Guid Shipment { get; set; }
    }
}
