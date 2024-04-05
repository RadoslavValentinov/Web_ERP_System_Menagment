﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System_Menagment_Infrastuctor.Data.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public decimal SalePrice { get; set; }


        [Required]
        public decimal GoodPrice { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
