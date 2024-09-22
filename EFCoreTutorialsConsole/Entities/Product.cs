using System;
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
        [Column("Product Name", TypeName = "ntext")]
        public string? ProductName { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        // ForeignKey
        public Category? Category { get; set; } // FK -> PK 

        public void PrintInfo() => Console.WriteLine($"{ProductId} - {ProductName} - {Price}");
    }
}
