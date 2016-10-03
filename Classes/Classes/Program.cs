using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            House mansion = new House(3,10);
            mansion.HasWindows = true;
            mansion.HowManyWindows = 20;

            House shack = new House(1, 0);
            shack.HasWindows = false;

            Restaurant fancyJas = new Restaurant(4, 33);
            fancyJas.CashRegister = true;

            Restaurant jerryBbq = new Restaurant(1, 0);
            jerryBbq.CashRegister = false;

            City lasJas = new City(500);
            lasJas.Lake = true;
            lasJas.HowManyLakes = 7;
            lasJas.Police = false;

            City hood = new City(350);
            hood.Lake = true;
            hood.HowManyLakes = 1;
            hood.Police = true;

            Console.ReadLine();



                
                

            
        }
    }
}
