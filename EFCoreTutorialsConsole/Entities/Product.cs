﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorialsConsole.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? ProductName { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Provider { get; set; }

        public void PrintInfo() => Console.WriteLine($"{ProductId} - {ProductName} - {Provider}");
    }
}
