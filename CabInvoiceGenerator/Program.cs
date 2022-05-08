using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-Welcome To The Cab Invoice Generator Program-=-=-=-=-=");
            CabInvoiceGen cabInvoiceGenerator = new CabInvoiceGen(RideType.NORMAL);
            Console.WriteLine(cabInvoiceGenerator.CalculateFare(10, 15));
            Console.ReadLine();
        }
    }
}
