using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program assumes that you have only Final Value fees and paypal fees."); 
            Console.WriteLine("It doesn't include insertion fees or other fees");
            Console.WriteLine();

            Console.Write("Enter Selling Price:");
            var SellingPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter shipping price charged to buyer:");
            var ShippingChargedToBuyer = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter actual shipping cost:");
            var ShippingCostToYou = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            var TotalSellingPrice = SellingPrice + ShippingChargedToBuyer;

            var PaypalFee = TotalSellingPrice * .029m + .30m;

            var EbayFee = TotalSellingPrice * .10m;

            var TotalFees = PaypalFee + EbayFee;

            var Profit = TotalSellingPrice - TotalFees - ShippingCostToYou;

            Console.Write("Profit:");
            Console.WriteLine(Profit);

            Console.Write("Ebay Fee:");
            Console.WriteLine(EbayFee);

            Console.Write("Paypal Fee:");
            Console.WriteLine(PaypalFee);

            Console.ReadLine();

        }
    }
}
