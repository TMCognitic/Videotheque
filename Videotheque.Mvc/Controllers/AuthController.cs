using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Videotheque.Models.Interfaces;
using Videotheque.Mvc.Models;
using Videotheque.UI.Models.Client.Entities;

namespace Videotheque.Mvc.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService<User> _authService;

        public AuthController(IAuthService<User> authService)
        {
            _authService = authService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterForm form)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _authService.Register(new User(form.LastName, form.FirstName, form.Email, form.Passwd));
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = ex.Message;
                }                
            }

            return View(form);
        }
    }
}
