
using EfCodeFirstCleanCode.DataAccessLayer.Repository;
using EfCodeFirstCleanCode.Entity.Models;
using System;
using System.Collections.Generic;

namespace EfCodeFirstCleanCode
{
    class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
           
            // ÜRÜN EKLEME
            Product product = new Product();
            product.ProductName = "TEST ÜRÜN 01";
            product.ProductCode = 01;
            product.ProductDescription = "BU İLK ÜRÜNDÜR";
            product.ProductDescription = "01 KODLU ÜRÜN AÇIKLAMASI";
            product.ProductPrice = 100;
            product.ProductStatus = true;

            GenericRepository<Product>  pgr = new GenericRepository<Product>();
            pgr.Insert(product);
            try
            {
                Console.WriteLine("Ürün Eklendi");
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
            }

            //KATEGORİ EKLEME
            Category category = new Category();
            category.CategoryName = "ARABA";
            category.CategoryDescription = "ARABA ÜRÜNLERİ BURADA OLACAK";
            category.CategoryStatus = true;
            GenericRepository<Category> cgr = new GenericRepository<Category>();
            cgr.Insert(category);
            try
            {
                Console.WriteLine("Kategori Eklendi");
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
            }


            //ÜRÜN LİSTELEME


            // ÜRÜN SİLME
            var productid = pgr.GetByID(1);
            try
            {
                pgr.Delete(productid);
                Console.WriteLine("1 Numaralı Ürün Silindi");
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata);
            }
          


         


        }
    }
}
