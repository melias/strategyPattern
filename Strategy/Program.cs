using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoicePersonal = new Invoice("Maykon Elias", 1000, TypeInvoice.personal);
            var invoiceCompany = new Invoice("Melias Company", 5000, TypeInvoice.company);
            var invoicePersonalWithDiscount = new Invoice("Jones Kappa", 1000, TypeInvoice.personalWithDiscount);

            var processInvoice = new ProcessInvoice();

            processInvoice.Process(invoicePersonal);
            processInvoice.Process(invoiceCompany);
            processInvoice.Process(invoicePersonalWithDiscount);

            Console.Read();
        }
    }
}