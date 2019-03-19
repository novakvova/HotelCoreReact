using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebSiteCore.Helpers.Attributes;

namespace WebSiteCore.ViewModels
{
    public class OrderViewModel
    {
        [ActualDate(ErrorMessage = "Starting date isn`t valid")]
        [Required(ErrorMessage = "Starting date of renting is required")]
        public DateTime From { get; set; }

        [ActualDate(ErrorMessage = "End date isn`t valid")]
        [Required(ErrorMessage = "End date of renting is required")]
        public DateTime To { get; set; }

        [Required(ErrorMessage = "Price of the rent is required")]
        public double Price { get; set; }

        [ExistentApartment]
        [Required(ErrorMessage = "Apartment of the rent is required")]
        public int ApartmentId { get; set; }

        [ExistentBoardType]
        [Required(ErrorMessage = "BoardType of the rent is required")]
        public int BoardTypeId { get; set; }

        [ExistentClientId]
        [Required(ErrorMessage = "Client of the rent is required")]
        public string ClientId { get; set; }
    }
}
