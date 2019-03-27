using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteCore.DAL.Entities;

namespace WebSiteCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly EFDbContext _ctx;
        public OfferController(EFDbContext _ctx)
        {
            this._ctx = _ctx;
        }
        public IActionResult Get()
        {
            var offers = _ctx.Offers.ToList();
            if (offers != null)
            {
                return Ok(offers);
            }
            return BadRequest("No offers were found");
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var offer = _ctx.Offers.SingleOrDefault(o => o.Id == id);
            if (offer != null)
            {
                return Ok(offer);
            }
            return BadRequest("The offer with specified id wasn`t found");
        }
    }
}