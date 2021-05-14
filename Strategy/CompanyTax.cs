namespace Strategy
{
    public class CompanyTax : ITax
    {
        public void Calculate(Invoice invoice)
        {
            invoice.AddValueWithTax(invoice.Value * 1.23);
        }
    }
}
