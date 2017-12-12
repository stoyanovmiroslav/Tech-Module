using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "ReadMe")
            {
                bool invalid = false;
                int containSpace = input.IndexOf(" ");
                int containUnderScore = input.IndexOf("_");
                if ((containSpace >= 0 || containUnderScore >=0) && input.Length >=3)
                {
                    Console.WriteLine("NO");
                    continue;
                }
                
                int count = input.Length / 4;
                int index = 3;

                double sum = 3;
                for (int i = 0; i < count; i++)
                {
                    sum += 4;
                }

                if (input.Length != sum)
                {
                    invalid = true;
                }

                for (int i = 0; i < count; i++)
                {
                    if (input[index] != '.' && index < input.Length - 3)
                    {
                        invalid = true;
                        break;
                    }
                    index += 4;
                  
                }

                if (!invalid)
                {
                    char[] arr = input.ToCharArray();
                    for (int i = 0; i < arr.Length / 2; i++)
                    {
                        if (arr[i] != arr[arr.Length - 1 - i])
                        {
                            invalid = true;
                            break;
                        }
                    }

                }
                if (invalid)
                {
                    Console.WriteLine("NO");
                }
                else

                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
