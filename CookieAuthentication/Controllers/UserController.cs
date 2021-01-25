using Microsoft.AspNetCore.Mvc;

namespace CookieAuthentication.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class UserController : Controller
    {

        [HttpGet("[action]")]
        public UserModel GetUser()
        {

            var model = new UserModel
            {
                IsAuthenticated = false,
                UserName = "[]"
            };

            if (!(User?.Identity?.IsAuthenticated ?? false)) return model;
            
            model.IsAuthenticated = true;
            model.UserName = User.Identity.Name;

            return model;
        }
        
        
    }

    public class UserModel
    {
        public string UserName { get; set; }

        public bool IsAuthenticated { get; set; }
    }
}