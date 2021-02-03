using System.Collections.Generic;

namespace DesignPatterns.Structural.Facade
{
    public class Product
    {
        public Dictionary<string, double> ProductList
        {
            get
            {
                Dictionary<string, double> products = new Dictionary<string, double>();
                products.Add("Calculator", 9.99);
                products.Add("Smart Watch", 139.99);
                products.Add("Cell Phone", 799.99);
                products.Add("Television", 999.99);
                return products;
            }
        }

        public string ProductListToString()
        {
            string output = "";

            foreach (var product in ProductList)
                output += $"{product.Key} - ${product.Value}\r\n";

            return output;
        }
    }
}
