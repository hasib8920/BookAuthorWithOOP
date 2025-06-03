using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthorWithOOP.Models
{
    public class InfoPrinter<T>:IInfo<T> where T : EnityBase, new()
    {
        public void Info(T o)
        {
            Console.WriteLine(o.Info());
        }
    }
}
