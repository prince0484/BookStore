﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entity
{
    public class BookCategory
    {
        public int Id { get; set; }
        public int BookId {  get; set; }
        public int Category { get; set; }
    }
}
