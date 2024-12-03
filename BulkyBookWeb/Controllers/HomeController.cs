using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BulkyBookWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            Choice choice9 = new Choice();
            choice9.Video = "video11.mp4";
            choice9.End = true;

            Choice choice8 = new Choice();
            choice8.Video = "video10.mp4";
            choice8.End = true;

            Choice choice7 = new Choice();
            choice7.Video = "video9.mp4";
            choice7.End = true;

            Choice choice6 = new Choice();
            choice6.Video = "video8.mp4";
            choice6.End = true;

            Choice choice5 = new Choice();
            choice5.ChoiceOne = choice9;
            choice5.ChoiceTwo = choice8;
            choice5.ChoiceOneText = "Attendre";
            choice5.ChoiceTwoText = "Faire distraction";
            choice5.Video = "video5.mp4";
            choice5.Loop = "loop4.mp4";
            choice5.End = false;

            Choice choice4 = new Choice();
            choice4.ChoiceOne = choice7;
            choice4.ChoiceTwo = choice6;
            choice4.ChoiceOneText = "S'enfuir à travers la fôret";
            choice4.ChoiceTwoText = "Aller se cacher derrière un arbre";
            choice4.Video = "video4-6.mp4";
            choice4.Loop = "loop3.mp4";
            choice4.End = false;

            Choice choice3 = new Choice();
            choice3.ChoiceOne = choice8;
            choice3.ChoiceTwo = choice9;
            choice3.ChoiceOneText = "Faire distraction";
            choice3.ChoiceTwoText = "Attendre";
            choice3.Video = "video3.mp4";
            choice3.Loop = "loop4.mp4";
            choice3.End = false;

            Choice choice2 = new Choice();
            choice2.ChoiceOne = choice4;
            choice2.ChoiceTwo = choice5;
            choice2.ChoiceOneText = "Suivre le cri";
            choice2.ChoiceTwoText = "Ignorer";
            choice2.Video = "video2.mp4";
            choice2.Loop = "loop2.mp4";
            choice2.End = false;

            Choice choice1 = new Choice();
            choice1.ChoiceOne = choice2;
            choice1.ChoiceTwo = choice3;
            choice1.ChoiceOneText = "Aller vers le mouvement";
            choice1.ChoiceTwoText = "Continuer son chemin";
            choice1.Video = "video1.mp4";
            choice1.Loop = "loop1.mp4";
            choice1.End = false;

            return View(choice1);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Choice([FromBody] Choice choice)
        {
            return View(choice);
        }

    }
}