﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistriBook.Models.ViewModels
{
    public class OrderVM
    {
        public OrderHeaderModel OrderHeader { get; set; }
        public IEnumerable<OrderDetailModel> OrderDetail { get; set; }
    }
}
