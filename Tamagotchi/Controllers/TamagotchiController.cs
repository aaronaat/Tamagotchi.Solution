using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamagotchiController : Controller
  {

    [HttpGet("/tamagotchi")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/tamagotchi/start")]
    public ActionResult CreateTamagotchi()
    {
      Tam myTam = new Tam(0,0,0);
      return View("Index");
    }

    [HttpPost("/tamagotchi/feed")]
    public ActionResult Feed()
    {
      string food = myTam.GetFood() + 1;
      myTam.SetFeed(food);
      return View("Index");
    }
    [HttpPost("/tamagotchi/play")]
    public ActionResult Play()
    {
      string play = myTam.GetPlay() + 1;
      myTam.SetPlay(play);
      return View("Index");
    }
    [HttpPost("/tamagotchi/feed")]
    public ActionResult Sleep()
    {
      string sleep = myTam.GetSleep() + 1;
      myTam.SetSleep(sleep);
      return View("Index");
    }

  }

}
