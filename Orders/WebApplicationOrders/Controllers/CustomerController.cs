﻿using Microsoft.AspNetCore.Mvc;
using Entities.Models;
using ProxyService.Interfaces;
using ProxyService;

namespace WebApplicationOrders.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomerProxy _proxy;
        public CustomersController()
        {
            this._proxy = new CustomerProxy();
        }
        public async Task<IActionResult> Index()
        {
            var customers = await _proxy.GetAllAsync();
            return View(customers);
        }
    }
}