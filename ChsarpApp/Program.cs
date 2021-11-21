using System;

namespace ChsarpApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.productName = "Macbook Pro 2021";
            product1.price = 25000;
            product1.description = "16Gb Ram 512 Gb SSD";

            Product product2 = new Product();
            product2.productName = "Macbook Air 2021";
            product2.price = 12000;
            product2.description = "8Gb Ram 256 Gb SSD";

            Product[] products = new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine("       Product Name: " + product.productName + "\n" +
                                  "      Product Price: " + product.price + "\n" +
                                  "Product Descriptiom: " + product.description);
                Console.WriteLine("---------------------------------------------------");
            }

            ChartManager chartManager = new ChartManager();
            chartManager.add(product1);
            chartManager.add(product2);

            Console.WriteLine("\n\nMultiple adding process!");
            chartManager.add(products);

        }
    }
}
