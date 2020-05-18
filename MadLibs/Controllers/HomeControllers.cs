using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/vacation")]
    public ActionResult MadLibs(string adjective1, string adjective2, string noun1, string noun2, string pluralnoun1, string game, string pluralnoun2)
    {
      MadLibEntries madLib = new MadLibEntries();
      madLib.Adjective1 = adjective1;
      madLib.Adjective2 = adjective2;
      madLib.Noun1 = noun1;
      madLib.Noun2 = noun2;
      madLib.PluralNoun1 = pluralnoun1;
      madLib.Game = game;
      madLib.PluralNoun2 = pluralnoun2;
      return View(madLib);

    }
  }
}