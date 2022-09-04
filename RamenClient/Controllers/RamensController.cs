using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RamenClient.Models;

namespace RamenClient.Controllers
{
    public class RamensController : Controller
    {
        public IActionResult Index()
        {
            var allRamens = Ramen.GetRamens();
            return View(allRamens);
        }

        [HttpPost]
        public IActionResult Index(Ramen ramen)
        {
          Ramen.Post(ramen);
          return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
          var ramen = Ramen.GetDetails(id);
          return View(ramen);
        }

        public IActionResult Edit(int id)
        {
          var ramen = Ramen.GetDetails(id);
          return View(ramen);
        }

        [HttpPost]
        public IActionResult Details(int id, Ramen ramen)
        {
          ramen.RamenId = id;
          Ramen.Put(ramen);
          return RedirectToAction("Details", id);
        }

        public IActionResult Delete(int id)
        {
          Ramen.Delete(id);
          return RedirectToAction("Index");
        }
    }
}


