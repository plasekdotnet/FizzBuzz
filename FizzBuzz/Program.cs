using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i < 20)
            //{
            //    Console.WriteLine(i / 3 + " Modulo: " + i % 3);
            //    i++;
            //}

            var fizzBuzz = new FizzBuzz();
            Console.WriteLine("Podaj liczbę");

            while (true)
            {
                string string1 = fizzBuzz.GetValue();
                           
                 Console.WriteLine("Wynik : " + string1+ "\nJeżeli chcesz wyjść z aplikacji wpisz 't'.\nPodaj następną liczbę.");
            }

        }
       

      
    }
}
