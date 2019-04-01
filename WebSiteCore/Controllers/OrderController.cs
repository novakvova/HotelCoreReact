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
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var orders = _ctx.Orders.ToList();
        //    return Ok(orders);
        //}

        [HttpGet]
        public IActionResult Get([FromBody]DateRangeViewModel dataRange)
        {
            var orders = _ctx.Orders.Where(o => o.From >= dataRange.From && o.From <= dataRange.To)

                                    .OrderBy(o => o.From)
                                    .ThenBy(o => o.To)
                                    .Select(o => new
                                    {
                                        Id = o.Id,
                                        From = o.From,
                                        To = o.To,
                                        ApartmentId = o.ApartmentId
                                    })
                                    .ToList();
            return Ok(orders);
        }

        //[HttpPost]
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