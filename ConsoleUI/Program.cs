using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //CategoryTest();

            ProductManager product = new ProductManager(new EfProductDal());
            foreach (var products in product.GetProductDetails())
            {
                Console.WriteLine (products.ProductName + "/" + products.CategoryName);
            }
            
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            int cat_id = 4;
            Console.WriteLine("Get All");
            foreach (var product in productManager.GetAll())
            {

                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine($"Get All by Category id => {cat_id} ");
            foreach (var product in productManager.GetAllByCategoryId(cat_id))
            {
                Console.WriteLine(product.ProductId);
                Console.WriteLine(product.ProductName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            Console.WriteLine("*****************************************");
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}