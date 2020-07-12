using DataBaseCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseCore.ViewModel
{
    public class ProductShipmentViewModel
    {
      public  IEnumerable<Product> Products { get; set; }
        public IEnumerable<Shipment> Shipments { get; set; }
    }
}
