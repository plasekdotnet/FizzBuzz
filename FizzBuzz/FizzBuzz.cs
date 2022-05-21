using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
       /* private string WhatResult() 
        {

        }
       */
        public string GetValue()
        {
            while (true)
            {
                var string1 = " TEST";
                var val = Console.ReadLine();
                if (val.ToUpper() == "T")
                    Environment.Exit(0);

                if (!int.TryParse(val, out int number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie.");
                    continue;
                }

                if (number % 3 == 0 && number % 5 == 0)
                {
                    return string1 = "FizzBuzz";
                }
                if (number % 3 == 0)
                {
                    return string1 = "Fizz";
                }
                else if (number % 5 == 0)
                {
                    return string1 = "Buzz";
                }
                
                
                if (!(number % 3 == 0 && number % 5 == 0))
                {
                    return string1 = val;
                }
                return string1;
            }
        }
    }
}
