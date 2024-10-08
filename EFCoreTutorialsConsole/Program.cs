﻿using EFCoreTutorialsConsole.Entities;
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
            using var dbContext = new ShopContext();
            string dbName = dbContext.Database.GetDbConnection().Database;

            var results = dbContext.Database.EnsureCreated();
            if (results) { Console.WriteLine($"Tạo Db {dbName} thành công!"); }
            else { Console.WriteLine($"Không tạo được {dbName}");  }
        }

        static void DropDatabase()
        {
            Console.OutputEncoding= Encoding.UTF8;
            using var dbContext = new ShopContext();
            string dbName = dbContext.Database.GetDbConnection().Database;

            var results = dbContext.Database.EnsureDeleted();
            if (results) { Console.WriteLine($"Xóa Db {dbName} thành công!"); }
            else { Console.WriteLine($"Không xóa được {dbName}"); }
        }

        #region EF_1
        //static void InsertProduct()
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    using var dbContext = new ShopContext();

        //    var products = new object[]
        //    {
        //        new Product() { ProductName = "Sản phẩm 3", Provider = "CTY A" },
        //        new Product() { ProductName = "Sản phẩm 4", Provider = "CTY B" },
        //        new Product() { ProductName = "Sản phẩm 5", Provider = "CTY C" },
        //    };

        //    dbContext.AddRange(products);
        //    int number_rows = dbContext.SaveChanges();
        //    Console.WriteLine($"Đã chèn {number_rows} dữ liệu!");
        //}

        //static void ReadProducts()
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    using var dbContext = new ShopContext();
        //    var products = dbContext.Products.ToList();
        //    products.ForEach(product => product.PrintInfo());
        //}

        //static void RenameProduct(int id, string newName, string newProvider)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    using var dbContext = new ShopContext();
        //    Product product = (from p in dbContext.Products
        //                       where p.ProductId == id
        //                       select p).FirstOrDefault()!;
        //    if (product != null)
        //    {
        //        product.ProductName = newName;
        //        product.Provider = newProvider;
        //        int number_rows = dbContext.SaveChanges();
        //        Console.WriteLine($"Đã cập nhật {number_rows} dữ liệu!");
        //    }
        //}

        //static void DeleteProduct(int id)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    using var dbContext = new ShopContext();
        //    Product product = (from p in dbContext.Products
        //                       where p.ProductId == id
        //                       select p).FirstOrDefault()!;
        //    if (product != null)
        //    {
        //        dbContext.Remove(product);
        //        int number_rows = dbContext.SaveChanges();
        //        Console.WriteLine($"Đã xóa {number_rows} dữ liệu!");
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {
            CreateDatabase();
            //DropDatabase();

            //Insert, Select, Update, Delete
            //InsertProduct();
            //ReadProducts();
            //RenameProduct(4, "Sản phẩm 4", "CTY B");
            //DeleteProduct(5);

            //Logging
            //RenameProduct(4, "Oppo Reno 12T", "Oppo");
            //ReadProducts();
        }
    }
}