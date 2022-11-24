using BusinessLayer.Abstract;
using DataAccess.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Threading.Tasks;

namespace AdminSchool.Controllers
{

    public class LoginController : Controller
    {
        Context c = new Context();
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GirisYap(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(User user)
        {
            var information = c.Users.FirstOrDefault(x => x.userName == user.userName && x.password == user.password);
            if (information != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.userName),
                    
                };

                var identity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);

                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return View();
        }
        [HttpGet]
        public IActionResult UyeOl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UyeOl(User user)
        {

            
            return RedirectToAction("LoginPanel");

        }
    }
    }
