using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorialsConsole.Models
{
    public class ProductDbContext : DbContext
    {
        private const string connectionString = "Data Source=Rainy;Initial Catalog=EFCoreTutorialsConsole;Integrated Security=True;Trust Server Certificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
