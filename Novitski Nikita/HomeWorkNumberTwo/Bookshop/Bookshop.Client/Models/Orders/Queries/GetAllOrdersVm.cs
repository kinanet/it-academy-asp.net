﻿using Bookshop.Domain.Models.Entities;
using System.Collections.Generic;

namespace Bookshop.Client.Models.Orders.Queries
{
    public class GetAllOrdersVm
    {
       public List<Order> Orders { get; set; }
    }
}