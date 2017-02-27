using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_IComparableRichestBuisnessman_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var BuisnessMen = new List<BuisnessMan>
            {
                new BuisnessMan { Name = "Arnold", ValueOfBuisness = 8000, ValueOfCar = 200, ValueOfHouse = 3000 },
                new BuisnessMan { Name = "Brandor", ValueOfBuisness = 3000, ValueOfCar = 0, ValueOfHouse = 5000 },
                new BuisnessMan { Name = "Cyrill", ValueOfBuisness = 6000, ValueOfCar = 40, ValueOfHouse = 50 },
                new BuisnessMan { Name = "Dean", ValueOfBuisness = 13, ValueOfCar = 444, ValueOfHouse = 10000 },
                new BuisnessMan { Name = "Ester", ValueOfBuisness = 0, ValueOfCar = 0, ValueOfHouse = 10 },
                new BuisnessMan { Name = "Franky", ValueOfBuisness = 5000, ValueOfCar = 5000, ValueOfHouse = 5000 }
            };

            //Spadne ak elementy listu niesú porovnateľné
            BuisnessMen.Sort();

            Console.WriteLine("Skutocnost: ");
            Console.WriteLine("Ester Cyrill Brandor Dean Arnold Franky");
            Console.WriteLine("Vase zoradenie: ");
            foreach(var bman in BuisnessMen)
            {
                Console.Write(bman.Name + " " );
            }
            Console.ReadLine();

        }
    }
}
