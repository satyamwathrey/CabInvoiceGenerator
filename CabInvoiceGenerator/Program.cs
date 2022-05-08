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
            //UC1
            CabInvoiceGen cabInvoiceGenerator = new CabInvoiceGen(RideType.NORMAL);
            //Console.WriteLine(cabInvoiceGenerator.CalculateFare(10, 15));

            //UC2
            Ride[] multiRides = { new Ride(10, 15), new Ride(10, 15) };
            Console.WriteLine(cabInvoiceGenerator.CalculateAgreegateFare(multiRides));
            Console.ReadLine();
        }
    }
}
