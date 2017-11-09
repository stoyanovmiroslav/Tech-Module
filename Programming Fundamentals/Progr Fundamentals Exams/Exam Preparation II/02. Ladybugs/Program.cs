using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOftheField = int.Parse(Console.ReadLine());
            int[] indexOfLadybugs = Console.ReadLine().Split(new string[] { " ", }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] field = new int[sizeOftheField];

           


            for (int i = 0; i < field.Length; i++)
            {
                if (indexOfLadybugs.Contains(i))
                {
                    field[i] = 1;
                }
            }
            
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] splitCommand = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int index = int.Parse(splitCommand[0]);

                
                string commandToFly = splitCommand[1];
                int flyLenght = int.Parse(splitCommand[2]);

              if(index > field.Length - 1 || index < 0)
              {
                  continue;
              }        
             

                if (commandToFly == "left")
                {
                    FlyLeft(field, index, flyLenght);
                }
                else if(commandToFly == "right")
                {
                    FlyRight(field, index, flyLenght);
                }
                Console.WriteLine(String.Join(" ", field));

            }
            Console.WriteLine(String.Join(" ", field));
        }

        private static void FlyRight(int[] field, int index, int flyLenght)
        {
            if (field[index] == 1)
            {
                field[index] = 0;
            }
            else
            {
                 return;
            }

            while (true)
            {
                if (index + flyLenght < 0 || index + flyLenght > field.Length - 1)
                {
                    return;
                }
                else if (field[index + flyLenght] == 0)
                {
                    field[index+flyLenght] = 1;
                    return;
                }
                else
                {
                    flyLenght += flyLenght;
                }
            }
          
        }

        private static void FlyLeft(int[] field, int index, int flyLenght)
        {
            if (field[index] == 1)
            {
                field[index] = 0;
            }
            else
            {
                return;
            }

            while (true)
            {
                if (index - flyLenght < 0 || index - flyLenght > field.Length - 1)
                {
                    return;
                }
                else if (field[index - flyLenght] == 0)
                {
                    field[index - flyLenght] = 1;
                    return;
                }
                else
                {
                    flyLenght -= flyLenght;
                }
            }
        }
    }
}
