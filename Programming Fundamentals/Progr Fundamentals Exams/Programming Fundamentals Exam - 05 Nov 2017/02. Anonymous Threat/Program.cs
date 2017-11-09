using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dataInput = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands = "";
            while ((commands = Console.ReadLine()) != "3:1")
            {
                string[] spllitCommands = commands.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (spllitCommands.Length != 3)
                {
                    continue;
                }
                if (spllitCommands[0] == "divide")
                {
                    divide(dataInput, spllitCommands[1], spllitCommands[2]);
                }
                else if (spllitCommands[0] == "merge")
                {
                    merge(dataInput, spllitCommands[1], spllitCommands[2]);
                }
            }
            Console.WriteLine(String.Join(" ", dataInput));
        }

        private static void merge(List<string> dataInput, string startIndex, string endIndex)
        {
            int indexStart = int.Parse(startIndex);
            int indexEnd = int.Parse(endIndex);
            StringBuilder sb = new StringBuilder();
            
            if (indexEnd < indexStart || indexStart > dataInput.Count - 1)
            {
                return;
            }
            if (indexStart < 0)
            {
                indexStart = 0;
            }
            if (indexStart + indexEnd > dataInput.Count - 1)
            {
                indexEnd = dataInput.Count - 1;
            }

            for (int i = indexStart; i <= indexEnd; i++)
            {
                sb.Append(dataInput[i]);
            }
            int count = (indexEnd - indexStart) + 1;

            dataInput.RemoveRange(indexStart, count);
            dataInput.Insert(indexStart, sb.ToString());
        }

        private static void divide(List<string> dataInput, string index, string partitions)
        {
            int indexConverted = int.Parse(index);
            int partitionsConverted = int.Parse(partitions);
            int lenght = dataInput[indexConverted].Length;

            if (indexConverted < 0 || indexConverted > dataInput.Count - 1 || lenght < partitionsConverted || partitionsConverted < 0)
            {
                return;
            }

            int equalLenght = lenght / partitionsConverted;
            int leftElements = lenght % partitionsConverted;
            int counter = 0;

            for (int i = 0; i < partitionsConverted; i++)
            {
                if (i == partitionsConverted - 1)
                {
                    string appented = dataInput[indexConverted + i].Substring(counter, lenght - counter);
                    dataInput.Insert(indexConverted + i, appented);
                }
                else
                {
                    string appent = dataInput[indexConverted + i].Substring(counter, equalLenght);
                    dataInput.Insert(indexConverted + i, appent);
                    counter = equalLenght + counter;
                }
            }
            dataInput.RemoveAt(indexConverted + partitionsConverted);
        }
    }
}
