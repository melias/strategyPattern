namespace Strategy
{
    public class Invoice
    {
        public double Value { get; private set; }
        public string Name { get; private set; }

        public Invoice(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }

        public void AddValueWithTax(double newValue) 
        {
            this.Value = newValue;
        }
    }
}
