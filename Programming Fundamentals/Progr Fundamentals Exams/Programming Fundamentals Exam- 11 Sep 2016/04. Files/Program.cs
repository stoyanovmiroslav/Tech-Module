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
                string[] input = Console.ReadLine().Split(new string[] { "\\" } , StringSplitOptions.RemoveEmptyEntries);
                string root = input[0];
                string lastInput = input[input.Length - 1];
                string[] splitLastInput = lastInput.Split(';');
                string fileName = splitLastInput[0];
                string[] extension = fileName.Split('.');
                ulong fileSize = ulong.Parse(splitLastInput[1]);

                Files files = new Files();
                files.FileName = fileName;
                files.Root = root;
                files.Size = fileSize;
                files.Extension = extension[extension.Length-1];

                listOfFiles.Add(files);
            }
            string[] lastLineCommand = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string extensions = lastLineCommand[0];
            string roots = lastLineCommand[2];

            var dict = new Dictionary<string, ulong>();

            for (int i = 0; i < listOfFiles.Count; i++)
            {
                if (listOfFiles[i].Root == roots && listOfFiles[i].Extension == extensions)
                {
                    dict.Add(listOfFiles[i].FileName, listOfFiles[i].Size);
                }
            }
          
            foreach (var item in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} - {1} KB ", item.Key, item.Value);
            }
            if (dict.Count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
    class Files
    {
        public string FileName { get; set; }
        public string Root { get; set; }
        public ulong Size { get; set; }
        public string Extension { get; set; }

    }
}
