using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Files> listOfFiles = new List<Files>();
            for (int i = 0; i < n; i++)
            {
                ReadAndAddFiles(listOfFiles);
            }
            var dict = new Dictionary<string, long>();
            SelectAndAddDictionary(dict, listOfFiles);
            PrintOutput(dict);
        }

        private static void SelectAndAddDictionary(Dictionary<string, long> dict, List<Files> listOfFiles)
        {
            string[] lastLineCommand = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string extensions = lastLineCommand[0];
            string roots = lastLineCommand[2];
            for (int i = 0; i < listOfFiles.Count; i++)
            {
                if (listOfFiles[i].Root == roots && listOfFiles[i].Extension == extensions)
                {
                    if (!dict.ContainsKey(listOfFiles[i].FileName))
                    {
                        dict.Add(listOfFiles[i].FileName, listOfFiles[i].Size);
                    }
                    else
                    {
                        dict[listOfFiles[i].FileName] = listOfFiles[i].Size;
                    }
                }
            }
        }

        private static void PrintOutput(Dictionary<string, long> dict)
        {
            foreach (var item in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} - {1} KB ", item.Key, item.Value);
            }
            if (dict.Count == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static void ReadAndAddFiles(List<Files> listOfFiles)
        {
            string[] input = Console.ReadLine().Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            string root = input[0];
            string lastInput = input[input.Length - 1];
            string[] splitLastInput = lastInput.Split(';');
            string fileName = splitLastInput[0];
            string[] extension = fileName.Split('.');
            long fileSize = long.Parse(splitLastInput[1]);

            Files files = new Files();
            files.FileName = fileName;
            files.Root = root;
            files.Size = fileSize;
            files.Extension = extension[extension.Length - 1];

            listOfFiles.Add(files);
        }
    }
    class Files
    {
        public string FileName { get; set; }
        public string Root { get; set; }
        public long Size { get; set; }
        public string Extension { get; set; }

    }
}
