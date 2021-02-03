namespace DesignPatterns.Structural.Facade
{
    public class OrderProcessingFacade
    {
        public string ProcessOrder(string selectedProduct, string deliveryAddress)
        {
            string outputString = $"Processing order for {selectedProduct}...";
            Product product = new Product();

            if (!product.ProductList.ContainsKey(selectedProduct))
                return $"{selectedProduct} is not a valid product!";

            double productPrice = product.ProductList[selectedProduct];

            Order order = new Order();
            outputString += "\r\n" + order.ProcessPayment(productPrice, selectedProduct);

            Packer packer = new Packer();
            outputString += "\r\n" + packer.PreparePackage(selectedProduct, deliveryAddress);

            Carrier carrier = new Carrier();
            outputString += "\r\n" + carrier.ShipPackage(selectedProduct, deliveryAddress);

            return outputString;
        }
    }
}
