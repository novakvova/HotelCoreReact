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
            //var orders3 = _ctx.Orders.Where(o => o.From >= dataRange.From && o.From <= dataRange.To).ToList();
            //var orders2 = _ctx.Orders.Where(o => o.From >= dataRange.From && o.From <= dataRange.To)
            //                         .GroupBy(o => o.ApartmentId).ToList();
            var orders = _ctx.Orders.Where(o => o.From >= dataRange.From && o.From <= dataRange.To)
                                    .GroupBy(o => o.ApartmentId, 
                                            (key, items) => new { ApartId = key, Orders = items.ToList()})
                                    .ToList();
            var freeApartm = new Dictionary<int, int>();
            foreach(var group in orders)
            {
                int count = 1;
                var orderIds = new List<int>();
                for(int i = 0; i < group.Orders.Count(); i++)
                {
                    for(int j = i + 1; j < group.Orders.Count(); j++)
                    {
                        var fromI = group.Orders[i].From;
                        var fromJ = group.Orders[j].From;
                        var toI = group.Orders[i].To;
                        var toJ = group.Orders[j].To;

                        if ((fromI <= fromJ && toI >= fromJ ||
                            fromJ <= fromI && toJ >= fromI) && !orderIds.Contains(group.Orders[j].Id))
                        {
                            count++;
                            orderIds.Add(group.Orders[j].Id);
                        }
                    }
                }
                if(count < 3)
                {
                    freeApartm.Add(group.ApartId, 3 - count);
                }
            }
            return Ok(freeApartm);
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