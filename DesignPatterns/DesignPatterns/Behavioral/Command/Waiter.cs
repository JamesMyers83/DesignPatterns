using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Command
{
    //invoker
    public class Waiter
    {
        private List<IOrderCommand> customerOrders = new List<IOrderCommand>();

        public void TakeOrder(IOrderCommand order) => customerOrders.Add(order);
        public string PlaceOrders()
        {
            string output = "";

            foreach (IOrderCommand order in customerOrders)
                output += order.Execute() + "\r\n";

            return output;
        }
    }
}
