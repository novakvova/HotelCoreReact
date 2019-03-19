using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteCore.DAL.Entities;
using WebSiteCore.Helpers;
using WebSiteCore.Helpers.Mapping;
using WebSiteCore.ViewModels;

namespace WebSiteCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly EFDbContext _ctx;
        public OrderController(EFDbContext _ctx)
        {
            this._ctx = _ctx;
        }

        public IActionResult Post(OrderViewModel order)
        {
            if (!ModelState.IsValid)
            {
                var errrors = CustomValidator.GetErrorsByModel(ModelState);
                return BadRequest(errrors);
            }
            _ctx.Orders.Add(MapOrder.OrderVMToDM(order));
            _ctx.SaveChanges();
            return Ok("Success");
        }
    }
}