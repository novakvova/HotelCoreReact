using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSiteCore.ViewModels;

namespace WebSiteCore.Controllers
{
    public class OrderController : Controller
    {
        public async Task<IActionResult> MakeOrder([FromBody]OrderViewModel order)
        {

            return Ok();
        }
    }
}