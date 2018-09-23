using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/CreateForm")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/Result")]
        public ActionResult CreateResult()
        {
            RepeatCounter RepC = new RepeatCounter(Request.Form["new-words"],Request.Form["new-word"]);
            // RepC.SetWords(Request.Form["new-words"]);
            // RepC.SetWord(Request.Form["new-word"]);
            return View("Result", RepC);
        }
    }
}
