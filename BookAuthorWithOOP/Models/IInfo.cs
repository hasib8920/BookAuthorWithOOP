using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthorWithOOP.Models
{
    public interface IInfo<T> where T : EnityBase ,new()
    {
        void Info(T o);
    }
}
