using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> dictProductsAndPrice = new Dictionary<string, decimal>();
         

            for (int i = 0; i < numberOfProducts; i++)
            {
                string[] productPrice = Console.ReadLine()
                                      .Split('-');
                string product = productPrice[0];
                decimal price = decimal.Parse(productPrice[1]);

                if (!dictProductsAndPrice.ContainsKey(product))
                {
                    dictProductsAndPrice.Add(product, price);
                }
                else
                {
                    dictProductsAndPrice[product] = price;
                }
                                      
            }

            string[] nameProductQuantity = Console.ReadLine().Split('-', ',');
            List<Customer> listOfAllCustomer = new List<Customer>();
            int count = 0;
            while (nameProductQuantity[0] != "end of clients")
            {
                string name = nameProductQuantity[0];
                string product = nameProductQuantity[1];
                int quantity = int.Parse(nameProductQuantity[2]);
               

                if (dictProductsAndPrice.ContainsKey(product))
                {
                    Customer newCustomer = new Customer();
                    newCustomer.Name = name;
                    newCustomer.BoughtProductsQuantity.Add(product, quantity);
                    newCustomer.Bill += dictProductsAndPrice[product] * quantity;

                   if (listOfAllCustomer.Any(x => x.Name == name))
                    {
                        Customer existingCustomer = listOfAllCustomer.First(c => c.Name == name);
                   if (existingCustomer.BoughtProductsQuantity.ContainsKey(product))
                   {
                      existingCustomer.BoughtProductsQuantity[product] += quantity;
                      existingCustomer.Bill += dictProductsAndPrice[product] * quantity;
                    }
                   else
                   {
                       existingCustomer.BoughtProductsQuantity[product] = quantity;
                       existingCustomer.Bill += dictProductsAndPrice[product] * quantity;
                   }

                    }
                    else
                    {
                        listOfAllCustomer.Insert(count, newCustomer);
                        count++;
                    }
                 }

                nameProductQuantity = Console.ReadLine().Split('-', ',');
            }


            foreach (var item in listOfAllCustomer.OrderBy(x => x.Name))
            {
                Console.WriteLine("{0}", item.Name);
                  foreach (var productQuantity in item.BoughtProductsQuantity)
                  {
                      Console.WriteLine("-- {0} - {1}", productQuantity.Key, productQuantity.Value);
                  }
                Console.WriteLine("Bill: {0:F2}", item.Bill);
            }
            decimal totalBill = 0;
            foreach (var item in listOfAllCustomer)
            {
                totalBill += item.Bill;
            }
            Console.WriteLine("Total bill: {0:F2}", totalBill);
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> BoughtProductsQuantity = new Dictionary<string, int>();
        public decimal Bill { get; set; }
    }
}