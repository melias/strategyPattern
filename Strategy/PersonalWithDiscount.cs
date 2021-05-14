namespace Strategy
{
    public class PersonalWithDiscount : ITax
    {
        public void Calculate(Invoice invoice)
        {
            invoice.AddValueWithTax(invoice.Value * 1.12);
        }
    }
}
