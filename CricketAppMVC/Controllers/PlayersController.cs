using CricketAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CricketAppMVC.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> playerList = new List<Player>()
        {
            new(){PId=1,PName="V. Kohli",PType="Batsman",PCountry="India"},
            new(){PId=2,PName="Glenn Maxwell",PType="All-Rounder",PCountry="Australia"},
            new(){PId=3,PName="Syed Abdullah",PType="Bowler",PCountry="America"},
            new(){PId=4,PName="Mohd Rizwan",PType="Wicketkeeper",PCountry="Pakistan"},
            new(){PId=5,PName="Ricard Kettleborough",PType="Umpire",PCountry="England"}
        };
        public IActionResult Index()
        {
            ViewBag.msg = "We have Players from these Countries...";
            return View(playerList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create(Player player)
        {
            if(ModelState.IsValid)
            {
                playerList.Add(player);
                return RedirectToAction("Index");
            }
            return View(playerList);
        }
    }
}
