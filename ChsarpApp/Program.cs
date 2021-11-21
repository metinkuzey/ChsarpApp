using System;

namespace ChsarpApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.ProductName = "Macbook Pro 2021";
            product1.UnitPrice = 25000;
            product1.Description = "16Gb Ram 512 Gb SSD";

            Product product2 = new Product();
            product2.ProductName = "Macbook Air 2021";
            product2.UnitPrice = 12000;
            product2.Description = "8Gb Ram 256 Gb SSD";

            Product[] products = new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine("       Product Name: " + product.ProductName + "\n" +
                                  "      Product Price: " + product.UnitPrice + "\n" +
                                  "Product Descriptiom: " + product.Description);
                Console.WriteLine("---------------------------------------------------");
            }
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            Console.WriteLine("\n\nMultiple adding process!");
            productManager.Add(products);

            Product pr1 = new Product();
            pr1.Id = 1;
            pr1.CategoryId = 1;
            pr1.ProductName = "Macbook Pro 2021";
            pr1.UnitPrice = 25000;
            pr1.UnitsInStock = 120;
            pr1.Description = "16Gb Ram 512 Gb SSD";

            Product pr2 = new Product
            {
                Id = 2,
                CategoryId = 1,
                ProductName = "Macbook Air 2021",
                UnitPrice = 12000,
                UnitsInStock = 25,
                Description = "8Gb Ram 256 Gb SSD"
            };


            productManager.Add(pr1);
            productManager.Add(pr2);
            

        }
    }
}
