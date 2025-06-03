using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthorWithOOP.Models
{
    public class Author: EnityBase
    {
        public override int Id { get ; set ; }
        public string Name { get; set; }
        public string Email { get; set; }
        public override string Info()
        {
            return $"Author ID: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}
