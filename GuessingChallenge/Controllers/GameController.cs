using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingChallenge.Models
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["answer"] = new Random().Next(1, 11);
            return View();
        }

        private bool GuessWasCorrect(int guess) =>
            guess == (int)Session["answer"];
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GameModel model) //Latered refferred to the model state as a referrence to the requirments(max Characters etc..)
        {
            if (ModelState.IsValid)                             // Function of a ModelState talked about above
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);     //View Bag is it a way to read what the user is guessing?
            }
            return View(model);
        }
    }
}