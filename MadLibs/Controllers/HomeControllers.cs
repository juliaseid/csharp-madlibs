using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/vacationform")]
    public ActionResult VacationForm() { return View(); }
    [Route("/zooform")]
    public ActionResult ZooForm() { return View(); }

    [Route("/laborform")]
    public ActionResult LaborForm() { return View(); }

    public ActionResult Vacation(string adjective1, string adjective2, string noun1, string noun2, string pluralnoun1, string game, string pluralnoun2)
    {
      VacationEntries madLib = new VacationEntries();
      madLib.Adjective1 = adjective1;
      madLib.Adjective2 = adjective2;
      madLib.Noun1 = noun1;
      madLib.Noun2 = noun2;
      madLib.PluralNoun1 = pluralnoun1;
      madLib.Game = game;
      madLib.PluralNoun2 = pluralnoun2;
      return View(madLib);

    }

    [Route("/zoo")]

    public ActionResult Zoo(string adjective1, string animal1, string noun1, string verbpast1, string adverb1, string adjective2, string noun2, string food, string color, string animal2)
    {
      ZooEntries madLib = new ZooEntries();
      madLib.Adjective1 = adjective1;
      madLib.Animal1 = animal1;
      madLib.Noun1 = noun1;
      madLib.VerbPast1 = verbpast1;
      madLib.Adverb1 = adverb1;
      madLib.Adjective2 = adjective2;
      madLib.Noun2 = noun2;
      madLib.Food = food;
      madLib.Color = color;
      madLib.Animal2 = animal2;
      return View(madLib);

    }

    [Route("/labor")]

    public ActionResult Labor(string name1, string verb1, string noun1, string noun2, string pluralnoun1, string name2, string verb2, string adjective2, string noun3)
    {
      LaborEntries madLib = new LaborEntries();
      madLib.Name1 = name1;
      madLib.Verb1 = verb1;
      madLib.Noun1 = noun1;
      madLib.Noun2 = noun2;
      madLib.PluralNoun1 = pluralnoun1;
      madLib.Name2 = name2;
      madLib.Verb2 = verb2;
      madLib.Adjective2 = adjective2;
      madLib.Noun3 = noun3;
      return View(madLib);

    }
  }
}