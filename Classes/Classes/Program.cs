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

            Console.WriteLine("This is a mansion");
            Console.WriteLine("This mansion has {0} rooms and {1} doors ", mansion.HowManyRooms, mansion.HowManyDoors);
            Console.WriteLine("My mansion has {0} windows", mansion.HowManyWindows);
            Console.WriteLine();
            Console.WriteLine();

            House shack = new House(1, 0);
            shack.HasWindows = false;
            Console.WriteLine("This is a shack");
            Console.WriteLine("I'm poor I have {0} rooms I only have {1} door to get in.", shack.HowManyRooms, shack.HowManyDoors);
            Console.WriteLine();
            Console.WriteLine();

            Restaurant fancyJas = new Restaurant(4, 33);
            fancyJas.CashRegister = true;
            Console.WriteLine("Welcome to Fancy Jas");
            Console.WriteLine("We have a large kitchen with {0} stoves!!", fancyJas.HowManyStoves);
            Console.WriteLine("We have {0} tables pick anyone to sit at", fancyJas.HowManyTables);
            Console.WriteLine();
            Console.WriteLine();

            Restaurant jerryBbq = new Restaurant(1, 0);
            jerryBbq.CashRegister = false;
            Console.WriteLine("Welcome To Jerry's Barbque");
            Console.WriteLine("We are a family restaurant with only {0} stove", jerryBbq.HowManyStoves);
            Console.WriteLine("We have {0} tables so togo orders only");
            Console.WriteLine();
            Console.WriteLine();

            City lasJas = new City(500);
            lasJas.Lake = true;
            lasJas.HowManyLakes = 7;
            lasJas.Police = false;
            Console.WriteLine("Welcome To Las Jas!!");
            Console.WriteLine("We have a population of {0}", lasJas.HowManyPpl);
            Console.WriteLine("If you love swiming we have {0} lakes", lasJas.HowManyLakes);
            Console.WriteLine();
            Console.WriteLine();

            City hood = new City(350);
            hood.Lake = true;
            hood.HowManyLakes = 1;
            hood.Police = true;
            Console.WriteLine("Welcome To The Hood");
            Console.WriteLine("We have a population of {0}", hood.HowManyPpl);
            Console.WriteLine("If you want to get wet we have {0} lakes", hood.HowManyLakes);

            Console.ReadLine();



                
                

            
        }
    }
}
