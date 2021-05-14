using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoicePersonal = new Invoice("Maykon Elias", 1000);
            var invoiceCompany = new Invoice("Melias Company", 5000);
            var invoicePersonalWithDiscount = new Invoice("Jones Kappa", 1000);

            var taxPersonal = new PersonalTax();
            var taxCompany = new CompanyTax();
            var taxPersonalWithDiscount = new PersonalWithDiscount();

            var processInvoice = new ProcessInvoice();

            processInvoice.Process(invoicePersonal, taxPersonal);
            processInvoice.Process(invoiceCompany, taxCompany);
            processInvoice.Process(invoicePersonalWithDiscount, taxPersonalWithDiscount);

            Console.Read();
        }
    }
}
