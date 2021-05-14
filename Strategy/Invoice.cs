namespace Strategy
{
    public class Invoice
    {
        public double Value { get; private set; }
        public string Name { get; private set; }
        public TypeInvoice Type { get; private set; }
        public Invoice(string name, double value, TypeInvoice typeInvoice)
        {
            this.Name = name;
            this.Value = value;
            this.Type = typeInvoice;
        }
        public void AddValueWithTax(double newValue) 
        {
            this.Value = newValue;
        }
    }
    public enum TypeInvoice
    {
        personal,
        company,
        personalWithDiscount
    }
}