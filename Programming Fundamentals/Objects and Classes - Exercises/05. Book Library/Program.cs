﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfBooks = int.Parse(Console.ReadLine());

            // List<Book> Books = new List<Book>();
            Library library = new Library();
            library.Books = new List<Book>();
            for (int i = 0; i < numbersOfBooks; i++)
            {
                string[] booksInfo = Console.ReadLine().Split(' ');
                Book addBookInfo = new Book();
                addBookInfo.Title = booksInfo[0];
                addBookInfo.Autor = booksInfo[1];
                addBookInfo.Publisher = booksInfo[2];
                addBookInfo.ReleaseDate = DateTime.ParseExact(booksInfo[3], "dd.MM.yyyy" , System.Globalization.CultureInfo.InvariantCulture);    
                addBookInfo.Isbn = double.Parse(booksInfo[4]);
                addBookInfo.Price = double.Parse(booksInfo[5]);

                library.Books.Add(addBookInfo);
            }

            Dictionary<string, double> booksByAutor = new Dictionary<string, double>();
            for (int i = 0; i < library.Books.Count; i++)
            {
                if (!booksByAutor.ContainsKey(library.Books[i].Autor))
                {
                    booksByAutor.Add(library.Books[i].Autor, 0);
                    booksByAutor[library.Books[i].Autor] += library.Books[i].Price;
                }
                else
                {
                    booksByAutor[library.Books[i].Autor] += library.Books[i].Price;
                }
            }

            foreach (var book in booksByAutor.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0:F2} -> {1:F2}", book.Key, book.Value);
            }
        }
    }
    class Library
    {
        public string name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Isbn { get; set; }
        public double Price { get; set; }

    }
}
