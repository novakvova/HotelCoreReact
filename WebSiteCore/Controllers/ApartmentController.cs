﻿using System;
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
            var apartments = _ctx.VApartmentsData.GroupBy(a => a.ApartmentId)
                                                 .Select(a => a.Take(1)
                                                               .Select(ap => new
                                                                {
                                                                    ap.Id,
                                                                    ap.ApartmentId,
                                                                    ap.Name,
                                                                    ap.Description,
                                                                    ap.Equipment,
                                                                    ap.Area,
                                                                    ap.Price,
                                                                    ap.RoomTypeId,
                                                                    ap.RoomTypeName,
                                                                    ap.RoomQuantity,
                                                                    ap.ConvenienceTypeId,
                                                                    ap.ConvenienceTypeName,
                                                                    ap.FloorId,
                                                                    ap.FloorNumber,
                                                                    ap.FloorDescription,
                                                                    Images = a.Select(apart => new { apart.AprtImageId, apart.AprtImageName })
                                                                })
                                                               .SingleOrDefault())
                                                 .ToList();

            ////////--------VOVA TEST-------------------
            //var groupData = from d in _ctx.VApartmentsData.AsQueryable()
            //                group d by new
            //                {
            //                    Id = d.ApartmentId,
            //                    d.Name

            //                } into g
            //                orderby g.Key.Name
            //                select g;

            //var resultObject = from g in groupData
            //                   select new
            //                   {
            //                       Id = g.Key.Id,
            //                       Name = g.Key.Name,
            //                       Images =
            //                       (from i in g
            //                        group i by new
            //                        {
            //                            Id = i.AprtImageId,
            //                            Name = i.AprtImageName
            //                        } into k
            //                        select k.Key)
            //                   };
            //var apartments = resultObject.ToList();
            ///////---------------------------------------

            //_ctx.VApartmentsData.ToList()
            //                                .GroupJoin(
            //                                    _ctx.ApartmentImages.ToList(),
            //                                    a => a.Id,
            //                                    i => i.AppartmentId,
            //                                    (apart, image) => new
            //                                    {
            //                                        Id = apart.Id,
            //                                        Name = apart.Name,
            //                                        Description = apart.Description,
            //                                        Equipment = apart.Equipment,
            //                                        Price = apart.Price,
            //                                        Area = apart.Area,
            //                                        RoomQuantity = apart.RoomQuantity,
            //                                        //Convenience = apart.Convenience,
            //                                       // Room = apart.Room,
            //                                        FloorNumber = apart.FloorNumber,
            //                                        FloorDescription = apart.FloorDescription,
            //                                        Images = image.Select(i => i.Name)
            //                                    });
            //var apartments = _ctx.Apartments
            //    .Include(a => a.ConvenienceType)
            //    .Include(a => a.RoomType)
            //    .Include(a => a.Floor)
            //    .Include(a => a.Images)
            //    .Select(a => new {
            //        Id = a.Id,
            //        Name = a.Name,
            //        Description = a.Description,
            //        Equipment = a.Equipment,
            //        Price = a.Price,
            //        Area = a.Area,
            //        RoomQuantity = a.RoomQuantity,
            //        ConvenienceType = a.ConvenienceType,
            //        RoomType = a.RoomType,
            //        Floor = a.Floor,
            //        Images = a.Images
            //    })
            //    .ToList();
            if (apartments != null)
            {
                return Ok(apartments);
            }
            return BadRequest("No apartments were found");
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var apartments = _ctx.VApartmentsData.Where(a => a.ApartmentId == id)
                                                 .Take(1)
                                                 .Select(ap => new
                                                  {
                                                      ap.Id,
                                                      ap.ApartmentId,
                                                      ap.Name,
                                                      ap.Description,
                                                      ap.Equipment,
                                                      ap.Area,
                                                      ap.Price,
                                                      ap.RoomTypeId,
                                                      ap.RoomTypeName,
                                                      ap.RoomQuantity,
                                                      ap.ConvenienceTypeId,
                                                      ap.ConvenienceTypeName,
                                                      ap.FloorId,
                                                      ap.FloorNumber,
                                                      ap.FloorDescription,
                                                      Images = a.Select(apart => new { apart.AprtImageId, apart.AprtImageName })
                                                  })
                                                  .SingleOrDefault()
                                                  .ToList();
            //var apartments = _ctx.Apartments
            //    .Where(a => a.Id == id)
            //    .Include(a => a.ConvenienceType)
            //    .Include(a => a.RoomType)
            //    .Include(a => a.Floor)
            //    .Include(a => a.Images)
            //    .Select(a => new {
            //        Id = a.Id,
            //        Name = a.Name,
            //        Description = a.Description,
            //        Equipment = a.Equipment,
            //        Price = a.Price,
            //        Area = a.Area,
            //        RoomQuantity = a.RoomQuantity,
            //        ConvenienceType = a.ConvenienceType,
            //        RoomType = a.RoomType,
            //        Floor = a.Floor,
            //        Images = a.Images
            //    })
            //    .SingleOrDefault();
            if (apartments != null)
            {
                return Ok(apartments);
            }
            return BadRequest("The apartment with specified id wasn`t found");
        }
    }
}