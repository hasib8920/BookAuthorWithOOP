using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthorWithOOP.Models
{
    public  class Book: EnityBase
    {
        public override int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        override public string Info()
        {
            return $"Book ID: {Id}, Title: {Title}, Genre: {Genre}, Price: {Price}";
        }
    }
}
