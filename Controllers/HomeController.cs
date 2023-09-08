using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using meetingapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace meetingapp.Controllers
{
    public class HomeController: Controller
    {
        //localhost
        //localhost/home
        //localhost/home/index
        public IActionResult Index(){

            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ? "Iyi gunler" : "Gunaydin";
            ViewBag.UserName = "Emirhan";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            //ViewData["Selamlama"] = saat > 12 ? "Iyi gunler" : "Gunaydin";
            //ViewData["UserName"] = "Emirhan";

            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "Istanbul ABC Kongre Merkezi",
                Date = new DateTime(2023, 12, 14, 20, 0, 0),
                NumberOfPeople = UserCount
            };
                
            return View(meetingInfo);
        }
    }
}