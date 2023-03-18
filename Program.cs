using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystal = 0;
            int convertGoldToCrystal;
            int priceGoldinCrystal = 15;

            Console.Write("Сколько у вас золота?: ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Один кристал стоит {priceGoldinCrystal}. Сколько кристалов вам нужно: ");
            convertGoldToCrystal = Convert.ToInt32(Console.ReadLine());

            if (gold >= priceGoldinCrystal)
            {
                crystal += convertGoldToCrystal;
                gold -= priceGoldinCrystal * convertGoldToCrystal;
            }
            else
            {
                Console.WriteLine($"Вам нехватает {priceGoldinCrystal - gold} золота.");
            }

            Console.WriteLine($"У вас имеется {gold} золота, и {crystal} кристала.");
        }
    }
}