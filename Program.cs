using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    internal class Program
    {

        //List<Pizza> pizzas = new List<Pizza>() {new Pizza("פיצה נפוליון", 1 ),
        //    new Pizza("פיצה אלכסנדר", 2),
        //    new Pizza("פיצה אברהם", 3) };
        static async Task Main(string[] args)
        {
            Pizza napoleon = new Pizza("נפוליון", 1);
            Pizza alexander = new Pizza("אלכסנדר", 2);
            Pizza abraham = new Pizza("אברהם", 3);

            maik(napoleon);
            maik(alexander);
            await maik(abraham);
            //await Task.Delay(1000000);
        }

        static async Task maik(Pizza pizza)
        {
            
            for(int i = pizza.Time * 60; i > 0; i-= 10 )
            {
                Console.WriteLine($"פיצה {pizza.Name} תהיה מוכנה בעוד {i } שניות.");
                await Task.Delay(10000); 
            }
            Console.WriteLine($"פיצה {pizza.Name} מוכנה!");
        }


        public class Pizza
        {
            public Pizza(string name, int time)
            {
                Name = name;
                Time = time;
            }

            public string Name { get; set; }
            public int Time { get; set; }
        }
    }
}
