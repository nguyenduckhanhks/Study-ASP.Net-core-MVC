using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lesson3.Models;

namespace Lesson3.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View(Product.GetProducts().Select(p => p.Name));
    }
}