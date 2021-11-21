using System;
namespace ChsarpApp
{
    public class ChartManager
    {
        public void add(Product product)
        {
            Console.WriteLine(product.productName + " is added to chart.");
        }

        public void add(Product[] product)
        {
            foreach (var productItem in product)
            {
                Console.WriteLine(productItem.productName + " is added to chart.");
                Console.WriteLine("---------------------------------------------------");
            }
            
        }
    }
}

