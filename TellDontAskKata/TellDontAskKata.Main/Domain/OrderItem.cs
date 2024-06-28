namespace TellDontAskKata.Main.Domain
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TaxedAmount { get; set; }
        public decimal Tax { get; set; }

        public static OrderItem From(Product product, int quantity)
        {
            var taxedAmount = Round(product.UnitaryTaxedAmount * quantity);
            var taxAmount = Round(product.UnitaryTax * quantity);

            return new OrderItem
            {
                Product = product,
                Quantity = quantity,
                Tax = taxAmount,
                TaxedAmount = taxedAmount
            };
        }
        private static decimal Round(decimal amount)
        {
            return decimal.Round(amount, 2, System.MidpointRounding.ToPositiveInfinity);
        }
    }
}
