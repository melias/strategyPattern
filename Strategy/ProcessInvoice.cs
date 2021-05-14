using System;

namespace Strategy
{
    public class ProcessInvoice
    {
        public void Process(Invoice invoice) 
        {
            if (invoice.Type == TypeInvoice.company)
            {
                invoice.AddValueWithTax(invoice.Value * 1.23);
            }
            else if (invoice.Type == TypeInvoice.personal)
            {
                invoice.AddValueWithTax(invoice.Value * 1.16);
            }
            else if (invoice.Type == TypeInvoice.personalWithDiscount)
            {
                invoice.AddValueWithTax(invoice.Value * 1.12);
            }
            else 
            {
                throw new Exception();
            }
            Console.WriteLine($"Invoice to '{invoice.Name}' generated with sucess, value with tax: {invoice.Value}");
        }
    }
}