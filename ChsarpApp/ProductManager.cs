using System;
namespace ChsarpApp
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " is added to chart.");
        }

        public void Add(Product[] product)
        {
            foreach (var productItem in product)
            {
                Console.WriteLine(productItem.ProductName + " is added to chart.");
                Console.WriteLine("---------------------------------------------------");
            }

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " is added to chart.");
        }
    }
}

