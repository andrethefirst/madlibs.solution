using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Intro() { return View(); }
    
    [Route("/game")]
    public ActionResult Game(string noun, string verb)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Noun = noun;
      myMadLibsVariable.Verb = verb;
      return View(myMadLibsVariable);
    }
    [Route("/next")]
    public ActionResult Next(string noun11, string verb22 , string noun12, string verb23, string noun13, string verb24)
    {
      MadLibsVariable myMadlibsVariable2 = new MadLibsVariable();
      myMadlibsVariable2.Noun11 = noun11;
      myMadlibsVariable2.Verb22 = verb22;
      myMadlibsVariable2.Noun12 = noun12;
      myMadlibsVariable2.Verb23 = verb23;
      myMadlibsVariable2.Noun13 = noun13;
      myMadlibsVariable2.Verb24 = verb24;
      return View(myMadlibsVariable2);
    }
  }
}