namespace Strategy
{
    public class PersonalTax : ITax
    {
        public void Calculate(Invoice invoice)
        {
            invoice.AddValueWithTax(invoice.Value * 1.16);
        }
    }
}
