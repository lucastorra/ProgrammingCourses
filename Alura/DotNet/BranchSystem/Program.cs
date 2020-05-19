using ByteBank;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BranchSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingDateTime();
            //CheckingAccount checkingAccount = new CheckingAccount(123, 1234);

        }

        public static void UsingDateTime()
        {
            DateTime datePayment = new DateTime(2020, 7, 25);
            DateTime today = DateTime.Now;

            TimeSpan diference = datePayment - today;


            Console.WriteLine(datePayment);
            Console.WriteLine(today);
            Console.WriteLine("A diferença é " + TimeSpanHumanizeExtensions.Humanize(diference));
            Console.ReadLine();
        }
    }
}
