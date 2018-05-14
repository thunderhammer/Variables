

namespace Variables
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)

        { }
        enum Køn // Default the first option = 0, the second = 1 ETC.
        {
            Mand,
            Kvinde
        }

        System.Int32 i; // Same as Int
            int x; // C# Shortname for System.int32
            i = 0;
            
            string tmp = i.ToString();

            long t = 10;
            bool g = true;
            double k = 10000.555;
            Console.WriteLine(k.ToString("N2"));
            Console.WriteLine(k);
            
            int e1;
            double e2;
            bool e3;

            DateTime d = DateTime.MinValue;
            DateTime d2 = DateTime.Now;
            DateTime d3 = new DateTime(2018, 12, 24); // Has to declare a new one since we create a DateTime object with a different definition
            Console.WriteLine(d3);
            
            Console.WriteLine(d3.ToString("yyyy dddd"));

            TimeSpan ts1 = d3.Subtract(d2);
            Console.WriteLine(ts1.TotalMinutes);

            TimeSpan ts2 = new TimeSpan(14, 00, 00);
            Console.WriteLine(ts2);
            Console.WriteLine(Variables.Properties.Settings.Default.Moms); //Accesses parameters
            i = 500000000;
            
           /* checked
            {
                short j = (short)i;
            } */

            // short j = Convert.ToInt16(i);

            DateTime d5 = Convert.ToDateTime("2017-5-15");
            var q = 1.5;

            int y = 100;
            int Y = 200;

            int antalMåneder = 12;

            String navn1 = "Mikkel";
            int køn1 = Køn;

            String navn2 = "Lene";
            int køn1 = Køn.1;

            Console.WriteLine(Convert.ToInt32(køn1));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Tryk på en tast...");
                Console.ReadKey();

            }
        }

