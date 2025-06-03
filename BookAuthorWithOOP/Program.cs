using BookAuthorWithOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthorWithOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InfoPrinter<Book> p1 = new InfoPrinter<Book>();
            InfoPrinter<Author> p2 = new InfoPrinter<Author>();
            Book A= new Book
            {
                Id = 1,
                Title = "C# Programming",
                Genre = "Education",
                Price = 500
            };
            p1.Info(A);
            Author B = new Author
            {
                Id = 2,
                Name = "Hasib Bhai",
                Email = "Hasib@gmail.com"
            };
            p2.Info(B);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
