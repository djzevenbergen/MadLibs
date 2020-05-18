using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
using System.Collections.Generic;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/formtwo")]

    public ActionResult FormTwo() { return View(); }

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

    [Route("/madlibtwo")]

    public ActionResult MadLibTwo(string name, string unrealisticprofession, string country, string sillyword, string color, string adjective, string adverb, string sillynameone, string sillynametwo, string facialfeature, string uscity, string sillynamethree, string verb, string nounone, string formerbadassactornowsellingout, string nountwo)
    {
      Dictionary<int, string> madLibInput = new Dictionary<int, string> { { 1, name }, { 2, unrealisticprofession }, { 3, country }, { 4, sillyword }, { 5, color }, { 6, adjective }, { 7, adverb }, { 8, sillynameone }, { 9, sillynametwo }, { 10, facialfeature }, { 11, uscity }, { 12, sillynamethree }, { 13, verb }, { 14, nounone }, { 15, formerbadassactornowsellingout }, { 16, nountwo } };
      MadLibInputs tempLibTwo = new MadLibInputs(madLibInput);
      return View(tempLibTwo);
    }


  }
}
