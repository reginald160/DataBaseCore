using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseCore.Models
{
    public class Supplier
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public Guid PrtoductId { get; set; }


    }
}
