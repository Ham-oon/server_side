using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using server_side.Models;

namespace server_side.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    public IActionResult ContactUs(Users user01)
        {
            List<Users> listusers = new List<Users>();
            Users prs1 = new Users();
            prs1.Id = 1;
            prs1.Name = "amir";
            prs1.Family = "ghahremani";
            prs1.Fathername = "ali";
            prs1.Password = "123456";
            prs1.Birthday = DateTime.Parse("1990/12/23");
            prs1.Gender = true;//true: man False: woman
            prs1.Active = true;
            listusers.Add(prs1);
            
            Users prs2 = new Users();
            prs2.Id = 2;
            prs2.Name = "mohammad";
            prs2.Family = "rezaee";
            prs2.Fathername = "reza";
            prs2.Password = "123";
            prs2.Birthday = DateTime.Parse("1991/12/23");
            prs2.Gender = true;//true: man False: woman
            prs2.Active = false;
            prs2.Height = 1.90f;
            listusers.Add(prs2);

            Users prs3 = new Users();
            prs3.Id = 3;
            prs3.Name = "mehdi";
            prs3.Family = "gholami";
            prs3.Fathername = "karim";
            prs3.Password = "12";
            prs3.Birthday = DateTime.Parse("2000/12/23");
            prs3.Gender = true;//true: man False: woman
            prs3.Active = true;
            prs3.Height = 1.89f;
            listusers.Add(prs3);

            Users prs4 = new Users();
            prs3.Id = 4;
            prs3.Name = "parsa";
            prs3.Family = "mirzaei";
            prs3.Fathername = "pasha";
            prs3.Password = "3355";
            prs3.Birthday = DateTime.Parse("2003/6/22");
            prs3.Gender = true;//true: man False: woman
            prs3.Active = true;
            prs3.Height = 1.87f;
            listusers.Add(prs4);

            var query = listusers.Where(x => x.Gender == true && x.Active == true).ToList();//.Tolist() , .count() , ||
                      //Link Lambda command^^^^^^^^^^^ 
            return View(query);
        }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
