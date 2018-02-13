using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class AnonymousVox
{
    static void Main(string[] args)
    {
        string input = "";
        var dictAnonymousCache = new Dictionary<string, Dictionary<string, long>>();
        var dictSelectedAnonymousCache = new Dictionary<string, Dictionary<string, long>>();

        List<string> listdataSet = new List<string>();


        while ((input = Console.ReadLine()) != "thetinggoesskrra")
        {
            string[] splitInput = input.Split(new string[] { " ", "-", ">", "|" }, StringSplitOptions.RemoveEmptyEntries);

            if (splitInput.Length == 3)
            {
                string dataKey = splitInput[0];
                long dataSize = long.Parse(splitInput[1]);
                string dataSet = splitInput[2];

                dataKeyDataSize(dictAnonymousCache, dataKey, dataSize, dataSet);
            }
            else if (splitInput.Length == 1)
            {
                string dataSet = splitInput[0];
                DataSet(listdataSet, dataSet);
            }

        }
        validDatasets(listdataSet, dictAnonymousCache, dictSelectedAnonymousCache);

      foreach (var item in dictSelectedAnonymousCache.OrderByDescending(x => x.Value.Values.Sum()))
      {
         Console.WriteLine("Data Set: {0}, Total Size: {1}", item.Key, item.Value.Values.Sum());
             
        foreach (var items in item.Value)
        {
            Console.WriteLine("$.{0}", items.Key);
        }
        break;
      }
    }

    private static void validDatasets(List<string> listdataSet, Dictionary<string, Dictionary<string, long>> dictAnonymousCache, Dictionary<string, Dictionary<string, long>> dictSelectedAnonymousCache)

    {
        for (int i = 0; i < listdataSet.Count; i++)
        {
            if (dictAnonymousCache.ContainsKey(listdataSet[i]))
            {
                dictSelectedAnonymousCache.Add(listdataSet[i], new Dictionary<string, long>());
                foreach (var item in dictAnonymousCache[listdataSet[i]])
                {

                    dictSelectedAnonymousCache[listdataSet[i]].Add(item.Key, item.Value);
                }
            }
        }
    }


    private static void dataKeyDataSize(Dictionary<string, Dictionary<string, long>> dictAnonymousCache, string dataKey, long dataSize, string dataSet)
    {
        if (!dictAnonymousCache.ContainsKey(dataSet))
        {
            dictAnonymousCache.Add(dataSet, new Dictionary<string, long>());
        }
        dictAnonymousCache[dataSet].Add(dataKey, dataSize);
    }

    private static void DataSet(List<string> listdataSet, string dataSet)
    {
        listdataSet.Add(dataSet);
    }
}


