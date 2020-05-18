using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
using System.Collections.Generic;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlibone")]
    public ActionResult MadLibOne(string name, string sillyword, string number, string adjectiveOne, string adjectiveTwo, string adjectiveThree, string adjectiveFour, string adjectiveFive, string noun, string verb, string relative)
    {
      // MadLibInputs tempLib = new MadLibInputs();
      // tempLib.WordOne = name;
      // tempLib.WordTwo = sillyword;
      // tempLib.WordThree = number;
      // tempLib.WordFour = adjectiveOne;
      // tempLib.WordFive = noun;
      // tempLib.WordSix = adjectiveTwo;
      // tempLib.WordSeven = relative;
      // tempLib.WordEight = adjectiveThree;
      // tempLib.WordNine = verb;
      // tempLib.WordTen = adjectiveFour;
      // tempLib.WordEleven = adjectiveFive;

      Dictionary<int, string> madLibInput = new Dictionary<int, string> { { 1, name }, { 2, sillyword }, { 3, number }, { 4, adjectiveOne }, { 5, noun }, { 6, adjectiveTwo }, { 7, relative }, { 8, adjectiveThree }, { 9, verb }, { 10, adjectiveFour }, { 11, adjectiveFive } };

      MadLibInputs tempLib = new MadLibInputs(madLibInput);

      return View(tempLib);
    }

    // [Route("/madlibtwo")]

    // public ActionResult MadLibTwo(string name, string unrealisticprofession, string country, string sillyword, string color, string adjective, string adverb, string sillynameone, string sillynametwo, string facialfeature, string uscity, string sillynamethree, string verb, string nounone, string formerlybadassactornowsellingout, string nountwo)
    // {
    //   MadLibInputs tempLibTwo = new MadLibInputs();
    // }


  }
}
