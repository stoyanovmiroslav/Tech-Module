using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int countLeft = 0;
                int currentCountLeft = 0;
                char currentSymbol = ' ';
                char symbol = ' ';
                
                char[] arr = input[i].ToCharArray();
                for (int j = 0; j < arr.Length / 2; j++)
                {
                    if((currentSymbol == ' ' || arr[j] == currentSymbol) && (arr[j] == '@' || arr[j] == '#' || arr[j] == '$' || arr[j] == '^'))
                    {
                        currentCountLeft++;
                       
                        if (currentCountLeft > countLeft)
                        {
                            currentSymbol = arr[j];
                            symbol = currentSymbol;
                            countLeft = currentCountLeft;
                        }
                    }
                    else if (arr[j] == '@' || arr[j] == '#' || arr[j] == '$' || arr[j] == '^')
                    {
                        currentCountLeft = 1;
                        currentSymbol = arr[j];
                    }
                    else
                    {
                       currentCountLeft = 0;
                       currentSymbol = ' ';
                    }
                   
                }
                int currentCountRight = 0;
                int countRight = 0;
                for (int k = arr.Length / 2; k < arr.Length; k++)
                {
                    if (arr[k] == symbol)
                    {
                        currentCountRight++;
                        if (currentCountRight > countRight)
                        {
                            countRight = currentCountRight;
                        }
                    }
                    else
                    {
                        currentCountRight = 0;
                    }
                }

                int symbolsLenght = Math.Min(countLeft, countRight);
                printOutput(symbolsLenght, symbol, arr, input[i]);
            }
        }

        private static void printOutput(int symbolsLenght, char symbol, char[] arr, string input)
        {
            if (arr.Length != 20)
            {
                Console.WriteLine("invalid ticket");
            }
            else if (symbolsLenght > 5 && symbolsLenght < 10)
            {
                Console.WriteLine("ticket \"{0}\" - {1}{2}", input, symbolsLenght, symbol);
            }
            else if (symbolsLenght == 10)
            {
                Console.WriteLine("ticket \"{0}\" - {1}{2} Jackpot!", input, symbolsLenght, symbol);
            }
            else
            {
                Console.WriteLine("ticket \"{0}\" - no match", input);
            }
        }
    }
}
