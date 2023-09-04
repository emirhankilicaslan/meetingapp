using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace meetingapp.Controllers
{
    public class HomeController: Controller
    {
        //localhost
        //localhost/home
        //localhost/home/index
        public IActionResult Index(){
            return View();
        }
    }
}