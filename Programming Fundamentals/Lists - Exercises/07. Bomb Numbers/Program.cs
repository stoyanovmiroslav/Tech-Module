using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToList();

            List<int> bombNumber = Console.ReadLine()
                               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToList();

            int startDamageIndex = 0;
            int rangeDamage = 0;
            int bombIndex = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber[0])
                {
                    rangeDamage = bombNumber[1];
                    bombIndex = i;
                    detonadeNumber(numbers, startDamageIndex, rangeDamage, bombIndex);

                    if (bombIndex - rangeDamage < 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = i - rangeDamage;
                    }                        
                }
            }
            int result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != bombNumber[0])
                {
                    result += numbers[i];
                }
            }
            Console.WriteLine(result);
        }

        private static void detonadeNumber(List<int> numbers, int startDamageIndex, int rangeDamage, int bombIndex)
        {
            startDamageIndex = bombIndex - rangeDamage;
            if (startDamageIndex < 0)
            {
                numbers.RemoveRange(0, rangeDamage + startDamageIndex);
                startDamageIndex = rangeDamage + startDamageIndex;
            }
            else
            {
                numbers.RemoveRange(startDamageIndex, rangeDamage);
                startDamageIndex = startDamageIndex + 1;
            }
           
            if (numbers.Count < (bombIndex - rangeDamage) + rangeDamage)
            {
                rangeDamage = (numbers.Count - 1) - (bombIndex - rangeDamage);
            }
            numbers.RemoveRange(startDamageIndex, rangeDamage);
        }
    }
}
