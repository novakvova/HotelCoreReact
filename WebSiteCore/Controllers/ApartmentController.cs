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
            var apartments = _ctx.VApartments.ToList()
                                             .GroupJoin(
                                                 _ctx.ApartmentImages.ToList(),
                                                 a => a.ApartmentId,
                                                 i => i.AppartmentId,
                                                 (a, i) => new
                                                 {
                                                     a.ApartmentId,
                                                     a.Name,
                                                     a.Description,
                                                     a.Equipment,
                                                     a.Area,
                                                     a.Price,
                                                     a.RoomTypeId,
                                                     a.RoomTypeName,
                                                     a.RoomQuantity,
                                                     a.ConvenienceTypeId,
                                                     a.ConvenienceTypeName,
                                                     a.FloorId,
                                                     a.FloorNumber,
                                                     a.FloorDescription,
                                                     Images = i.Select(image => new { image.Id, image.Name })
                                                 });

            //var apartments = _ctx.VApartmentsData.GroupBy(a => a.ApartmentId)
            //                                     .Select(a => a.Take(1)
            //                                                   .Select(ap => new
            //                                                    {
            //                                                        ap.Id,
            //                                                        ap.ApartmentId,
            //                                                        ap.Name,
            //                                                        ap.Description,
            //                                                        ap.Equipment,
            //                                                        ap.Area,
            //                                                        ap.Price,
            //                                                        ap.RoomTypeId,
            //                                                        ap.RoomTypeName,
            //                                                        ap.RoomQuantity,
            //                                                        ap.ConvenienceTypeId,
            //                                                        ap.ConvenienceTypeName,
            //                                                        ap.FloorId,
            //                                                        ap.FloorNumber,
            //                                                        ap.FloorDescription,
            //                                                        Images = a.Select(apart => new { apart.AprtImageId, apart.AprtImageName })
            //                                                    })
            //                                                   .SingleOrDefault())
            //                                     .ToList();

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
            object apartments = _ctx.VApartments.Where(a => a.ApartmentId == id)
                                                .ToList()
                                                .GroupJoin(
                                                    _ctx.ApartmentImages.ToList(),
                                                    a => a.ApartmentId,
                                                    i => i.AppartmentId,
                                                    (a, i) => new
                                                    {
                                                        a.ApartmentId,
                                                        a.Name,
                                                        a.Description,
                                                        a.Equipment,
                                                        a.Area,
                                                        a.Price,
                                                        a.RoomTypeId,
                                                        a.RoomTypeName,
                                                        a.RoomQuantity,
                                                        a.ConvenienceTypeId,
                                                        a.ConvenienceTypeName,
                                                        a.FloorId,
                                                        a.FloorNumber,
                                                        a.FloorDescription,
                                                        Images = i.Select(image => new { $"" })
                                                    });

            //var apartWithoutNavPropObjects = _ctx.VApartmentsData.Where(a => a.ApartmentId == id);
            //var apartments = apartWithoutNavPropObjects.Take(1)
            //                                           .Select(ap => new
            //                                            {
            //                                                ap.Id,
            //                                                ap.ApartmentId,
            //                                                ap.Name,
            //                                                ap.Description,
            //                                                ap.Equipment,
            //                                                ap.Area,
            //                                                ap.Price,
            //                                                ap.RoomTypeId,
            //                                                ap.RoomTypeName,
            //                                                ap.RoomQuantity,
            //                                                ap.ConvenienceTypeId,
            //                                                ap.ConvenienceTypeName,
            //                                                ap.FloorId,
            //                                                ap.FloorNumber,
            //                                                ap.FloorDescription,
            //                                                Images = apartWithoutNavPropObjects.Select(apart => new { apart.AprtImageId, apart.AprtImageName })
            //                                            })
            //                                           .ToList();

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