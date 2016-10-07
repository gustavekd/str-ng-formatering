using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_formatering
{
    class Program
    {
        static void Main(string[] args)
        //övning1

        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("D"));

            //övning2
            double cirkel = Math.PI * 4 * 4;
            Console.WriteLine(cirkel.ToString("F4"));

            //övning3
            int tal = 1000000000;
            Console.WriteLine(tal.ToString("0,0,0,"));

            //övning4
            double value = 123.00;
            Console.WriteLine(value.ToString("\\#\\#\\# ##0 kr och \\0\\0 öre \\#\\#\\#"));

            //övning5
            Console.WriteLine("mata in personnummer utan mellanslag:");
            string personnr = Console.ReadLine();
            decimal pntal = decimal.Parse(personnr);
            Console.WriteLine(pntal.ToString("#### ## ## - ####"));
        }
        
        

        
        

    }
}
