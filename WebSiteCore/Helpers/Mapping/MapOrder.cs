using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSiteCore.DAL.Entities;
using WebSiteCore.ViewModels;

namespace WebSiteCore.Helpers.Mapping
{
    public class MapOrder
    {
        public static Order OrderVMToDM(OrderViewModel order)
        {
            return new Order
            {
                From = order.From,
                To = order.To,
                Price = order.Price,
                ApartmentId = order.ApartmentId,
                BoardTypeId = order.BoardTypeId,
                ClientId = order.ClientId
            };
        }
    }
}
