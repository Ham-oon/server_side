using System.Diagnostics;
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
    public IActionResult ContactUs()
    {
        return View();

        int a = 10;
        string b ="in the name of god";
        float c = 123.45f;
        decimal d = 182.12312434m;
        int e = default;
        bool aa = default;

        // ارور هندلینگ با try catch

        try{

            string bb = "123465758abbb";
            int ab = int.Parse(bb);

        }
        catch(Exception ERR){

            // return ERR.Message;
        }

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
