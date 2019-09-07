using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestReponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                // TODO: store response from guest
                Repository.AddResponse(guestResponse);
                return View("thanks", guestResponse);
            }
            else
            {
                return View();
            }
            
        }

        public ViewResult ListReponses()
        {
            return View(Repository.Responses.Where(p => p.WillAttend == true));
        }

    }
}
