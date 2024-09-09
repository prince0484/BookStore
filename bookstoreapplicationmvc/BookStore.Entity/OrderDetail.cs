﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entity
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public String Bookname { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public int userId { get; set; }
        public DateTime Orderdate { get; set; }

    }
}
