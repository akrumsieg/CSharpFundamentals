using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to make a meal.");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen();
            Potato potato = new Potato();

            //synchronously peel a potato -- can't do other stuff
            potato.Peel();

            //asynchronously drop the fries -- can do other stuff
            var fries = kitchen.FryPotatoesAsync(potato);

            //synchronously assemble burger while fries are cooking
            var hamburger = kitchen.AssembleBurger();

            Console.WriteLine("Doing other stuff");

            kitchen.ServeMeal(fries.Result, hamburger); //use .Result bc var fries is a task not an object -- we collect the result here rather than above bc .Result is not async

            Console.ReadKey();
        }
    }
}
