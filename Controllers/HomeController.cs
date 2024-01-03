using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
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

    public IActionResult Users()
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
            listusers.Add(prs2);

            Users prs3 = new Users();
            prs3.Id = 3;
            prs3.Name = "ali";
            prs3.Family = "kamali";
            prs3.Fathername = "omid";
            prs3.Password = "456";
            prs3.Birthday = DateTime.Parse("2002/11/10");
            prs3.Gender = true;//true: man False: woman
            prs3.Active = true;
            listusers.Add(prs3);

            var query = listusers.ToList();
        return View(query);
    }

    public IActionResult About()
    {
        return View();
    }

    
    public IActionResult ContactUs(Product prd01)
        {
            
            List<Product> listprd = new List<Product>();
            Product prd1 = new Product();
            prd1.Id = 1;
            prd1.Name = "tombak - shirani Isfahan";
            prd1.Description = "3 Sign";
            prd1.Available = true;
            prd1.Price = 330;
            listprd.Add(prd1);

             Product prd2 = new Product();
            prd2.Id = 2;
            prd2.Name = "santoor";
            prd2.Description = "2 Sign";
            prd2.Available = true;
            prd2.Price = 560;
            listprd.Add(prd2);

             Product prd3 = new Product();
            prd3.Id = 3;
            prd3.Name = "daf - ahmadi";
            prd3.Description = "1 Sign";
            prd3.Available = true;
            prd3.Price = 280;
            listprd.Add(prd3);

             Product prd4 = new Product();
            prd4.Id = 4;
            prd4.Name = "kahken";
            prd4.Description = "yamaha";
            prd4.Available = true;
            prd4.Price = 490.5f;
            listprd.Add(prd4);
            
            

            var query = listprd.ToList();//.Tolist() , .count() , ||
                      //Link Lambda command^^^^^^^^^^^ 
            //var query = listprd.Where(x => x.Available ==true && x.Price >= 400).ToList();
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
