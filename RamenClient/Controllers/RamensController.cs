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
  }
}

