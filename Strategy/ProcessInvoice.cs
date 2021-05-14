using System;

namespace Strategy
{
    public class ProcessInvoice
    {
        public void Process(Invoice invoice, ITax tax) 
        {
            tax.Calculate(invoice);
            Console.WriteLine($"Invoice to '{invoice.Name}' generated with sucess, value with tax: {invoice.Value}");
        }
    }
}
