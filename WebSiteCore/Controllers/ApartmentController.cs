using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var apartments = _ctx.Apartments
                .Include(a => a.ConvenienceType)
                .Include(a => a.RoomType)
                .Include(a => a.Floor)
                .Include(a => a.Images)
                .Select(a => new {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    Equipment = a.Equipment,
                    Price = a.Price,
                    Area = a.Area,
                    RoomQuantity = a.RoomQuantity,
                    ConvenienceType = a.ConvenienceType,
                    RoomType = a.RoomType,
                    Floor = a.Floor,
                    Images = a.Images
                })
                .ToList();
            if(apartments != null)
            {
                return Ok(apartments);
            }
            return BadRequest("No apartments were found");
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var apartments = _ctx.Apartments
                .Where(a => a.Id == id)
                .Include(a => a.ConvenienceType)
                .Include(a => a.RoomType)
                .Include(a => a.Floor)
                .Include(a => a.Images)
                .Select(a => new {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description,
                    Equipment = a.Equipment,
                    Price = a.Price,
                    Area = a.Area,
                    RoomQuantity = a.RoomQuantity,
                    ConvenienceType = a.ConvenienceType,
                    RoomType = a.RoomType,
                    Floor = a.Floor,
                    Images = a.Images
                })
                .SingleOrDefault();
            if(apartments != null)
            {
                return Ok(apartments);
            }
            return BadRequest("The apartment with specified id wasn`t found");
        }
    }
}