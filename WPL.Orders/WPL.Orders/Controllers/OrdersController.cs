using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WPL.Orders.Domain;

namespace WPL.Orders.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        public IActionResult Get()
        {
            return Ok(new List<Order>
            {
                new Order {Description = "Item 1", Id = Guid.NewGuid()},
                new Order {Description = "Item 2", Id = Guid.NewGuid()}
            });
        }
    }
}