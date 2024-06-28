namespace TellDontAskKata.Main.Domain
{
    public class OrderItem
    {
        public string Name { get; private set; }
        public decimal UnitaryPrice { get; private set; }

        public int Quantity { get; set; }
        public decimal TaxedAmount { get; set; }
        public decimal Tax { get; set; }

        public static OrderItem From(Product product, int quantity)
        {
            return new OrderItem
            {
                Name = product.Name,
                UnitaryPrice = product.Price,
                Quantity = quantity,
                Tax = Round(product.UnitaryTax * quantity),
                TaxedAmount = Round(product.UnitaryTaxedAmount * quantity)
            };
        }

        private static decimal Round(decimal amount)
        {
            return decimal.Round(
                d: amount,
                decimals: 2,
                mode: System.MidpointRounding.ToPositiveInfinity);
        }
    }
}
