using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lesson2.Models;

namespace Lesson2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<String> resuilts = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name?? "<None>";
                Decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";

                resuilts.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
            }

            return View(resuilts);
        }
    }
}