using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebSiteCore.Controllers
{

    public class ViewUserModel
    {

        public string Name { get; set; }
        public string Email { get; set; }

    }

    [Route("api/[controller]")]
    [ApiController]
    public class ViewUsersController : ControllerBase
    {

        public ICollection<ViewUserModel> GetViewUsers()
        {
            List<ViewUserModel> getlist = new List<ViewUserModel>
            {
                new ViewUserModel{Name="test1",Email="E1"},
                new ViewUserModel{Name="test2",Email="E2"}
            };

            return getlist;
        }

    }
}