using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebSiteCore.DAL.Entities;

namespace WebSiteCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly EFDbContext _ctx;
        private IConfiguration _configuration;
        public ApartmentController(EFDbContext context, IConfiguration Configuration)
        {
            _ctx = context;
            _configuration = Configuration;
        }
        public IActionResult Get()
        {
            string imagePath = _configuration["Settings:ImagePath"];
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            //1
            var apartments = _ctx.VApartmentsData.GroupBy(a => new
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
                                                     a.FloorDescription
                                                 })
                                                .Select(a => new
                                                 {
                                                     apart = a.Key,
                                                     images = a.Select(ap => new { path = imagePath + ap.AprtImageName })
                                                 });
                                               //.Select(a => new
                                               //{
                                               //    id = a.Key.ApartmentId,
                                               //    name = a.Key.Name,
                                               //    description = a.Key.Description,
                                               //    equipment = a.Key.Equipment,
                                               //    area = a.Key.Area,
                                               //    price = a.Key.Price,
                                               //    roomTypeId = a.Key.RoomTypeId,
                                               //    roomTypeName = a.Key.RoomTypeName,
                                               //    roomQuantity = a.Key.RoomQuantity,
                                               //    convenienceTypeId = a.Key.ConvenienceTypeId,
                                               //    convenienceTypeName = a.Key.ConvenienceTypeName,
                                               //    floorId = a.Key.FloorId,
                                               //    floorNumber = a.Key.FloorNumber,
                                               //    floorDescription = a.Key.FloorDescription,
                                               //    images = a.Select(ap => new { path = imagePath + ap.AprtImageName })
                                               //});


            //2
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

            //3
            //var apartments = _ctx.VApartments.GroupJoin(
            //                                   _ctx.ApartmentImages.ToList(),
            //                                   a => a.ApartmentId,
            //                                   i => i.AppartmentId,
            //                                   (a, i) => new
            //                                   {
            //                                       a.ApartmentId,
            //                                       a.Name,
            //                                       a.Description,
            //                                       a.Equipment,
            //                                       a.Area,
            //                                       a.Price,
            //                                       a.RoomTypeId,
            //                                       a.RoomTypeName,
            //                                       a.RoomQuantity,
            //                                       a.ConvenienceTypeId,
            //                                       a.ConvenienceTypeName,
            //                                       a.FloorId,
            //                                       a.FloorNumber,
            //                                       a.FloorDescription,
            //                                       Images = i.Select(image => new { Path = imagePath + image.Name })
            //                                   });

            ////////--------VOVA TEST-------------------
            //_ctx.Database. = s => System.Diagnostics.Debug.WriteLine(s);
            //_ctx.ConfigureLogging(s => Console.WriteLine(s)); (s => Console.WriteLine(s));
            //_ctx.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());





            //4
            //var groupData = from a in _ctx.VApartmentsData.AsQueryable()
            //                group a by new
            //                {
            //                    Id = a.ApartmentId,
            //                    a.Name,
            //                    a.Description,
            //                    a.Equipment,
            //                    a.Area,
            //                    a.Price,
            //                    a.RoomTypeId,
            //                    a.RoomTypeName,
            //                    a.RoomQuantity,
            //                    a.ConvenienceTypeId,
            //                    a.ConvenienceTypeName,
            //                    a.FloorId,
            //                    a.FloorNumber,
            //                    a.FloorDescription
            //                } into g
            //                //orderby g.Key.Id
            //                select new
            //                {
            //                    g.Key.Id,
            //                    Image=from i in g select (new { i.AprtImageId})
            //                };

            //var apartments = groupData
            //    .OrderBy(a=>a.Id)
            //   //.Skip(0).Take(5)
            //   .ToList();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Debug.WriteLine("RunTime " + elapsedTime);

            //var resultObject = from g in groupData
            //                   select 

            //var apartments = resultObject.ToList();
            ///////---------------------------------------

            //5 Bad request
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
            string imagePath = _configuration["Settings:ImagePath"];
            object apartments = _ctx.VApartments.Where(a => a.ApartmentId == id)
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
                                                        Images = i.Select(image => new { Path = imagePath + image.Name })
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