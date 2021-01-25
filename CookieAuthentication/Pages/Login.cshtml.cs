using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieAuthentication.Pages
{
    [AllowAnonymous]
    public class Login : PageModel
    {
        public async Task<IActionResult> OnGetAsync(string username, string password)
        {
            
            //Compare this with database info

            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, username),
                new (ClaimTypes.Role, "Admin")
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                IsPersistent = true,
                RedirectUri = this.Request.Host.Value
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity), authProperties);
            return LocalRedirect(Url.Content("~/"));
        }
    }
}