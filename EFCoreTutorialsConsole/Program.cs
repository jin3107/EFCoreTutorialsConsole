using EFCoreTutorialsConsole.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EFCoreTutorialsConsole
{
    class Program
    {
        static void CreateDatabase()
        {
            Console.OutputEncoding = Encoding.UTF8;
            using var dbContext = new ProductDbContext();
            string dbName = dbContext.Database.GetDbConnection().Database;

            var results = dbContext.Database.EnsureCreated();
            if (results) { Console.WriteLine($"Tạo Db {dbName} thành công!"); }
            else { Console.WriteLine($"Không tạo được {dbName}");  }
        }

        static void DropDatabase()
        {
            Console.OutputEncoding= Encoding.UTF8;
            using var dbContext = new ProductDbContext();
            string dbName = dbContext.Database.GetDbConnection().Database;

            var results = dbContext.Database.EnsureDeleted();
            if (results) { Console.WriteLine($"Xóa Db {dbName} thành công!"); }
            else { Console.WriteLine($"Không xóa được {dbName}"); }
        }

        static void Main(string[] args)
        {
            //CreateDatabase();
            //DropDatabase();


        }
    }
}