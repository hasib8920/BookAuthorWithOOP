﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthorWithOOP.Models
{
    public abstract class EnityBase
    {
        public abstract int Id { get; set; }
        public abstract string Info();
    }
}
