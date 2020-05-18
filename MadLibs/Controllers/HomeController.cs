using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlibone")]
    public ActionResult MadLibOne(string name, string sillyword, string number, string adjectiveOne, string adjectiveTwo, string adjectiveThree, string adjectiveFour, string adjectiveFive, string noun, string verb, string relative)
    {
      MadLibInputs tempLib = new MadLibInputs();
      tempLib.Name = name;
      tempLib.SillyWord = sillyword;
      tempLib.Number = number;
      tempLib.Noun = noun;
      tempLib.Verb = verb;
      tempLib.Relative = relative;
      tempLib.AdjectiveOne = adjectiveOne;
      tempLib.AdjectiveTwo = adjectiveTwo;
      tempLib.AdjectiveThree = adjectiveThree;
      tempLib.AdjectiveFour = adjectiveFour;
      tempLib.AdjectiveFive = adjectiveFive;

      return View(tempLib);
    }
  }
}
