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
    public class ApartmentController : ControllerBase
    {
        private readonly EFDbContext _ctx;
        public ApartmentController(EFDbContext _ctx)
        {
            this._ctx = _ctx;
        }
        public IActionResult Get()
        {
            return Ok(_ctx.Apartments.ToList());
        }
    }
}