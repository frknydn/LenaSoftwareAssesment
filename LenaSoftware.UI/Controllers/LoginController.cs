using AutoMapper;
using LenaSoftware.DataAccess.Context;
using LenaSoftware.Entities.DbSets;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LenaSoftware.UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        readonly LenaSoftwareDbContext _db;
        public static User login;
        public LoginController(LenaSoftwareDbContext db)
        {
            _db = db;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var claim = new List<Claim>();
            login = _db.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            if (login != null)
            {
                claim.Add(new Claim(ClaimTypes.Role, "User"));
                var userIdentity = new ClaimsIdentity(claim, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("GetAll","Forms");
            }
            return View();

        }
    }
}
