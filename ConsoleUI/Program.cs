using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI 
{
    class Program 
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();

            
            
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
            Console.WriteLine("Get All");
            var result = productManager.GetAll();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {

                    Console.WriteLine(product.ProductName);
                    
                   
                }
            }
            else 
            {

                Console.WriteLine(result.Message);
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