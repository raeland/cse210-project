namespace OnlineOrder
{
    using System.Collections.Generic;
    using System.Text;

    public class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            this.products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double GetTotalCost()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.GetTotalCost();
            }

            total += customer.IsInUSA() ? 5 : 35;

            return total;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in products)
            {
                sb.AppendLine($"{product.GetName()} - {product.GetProductId()}");
            }

            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
        }
    }
}