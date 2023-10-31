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
    public IActionResult Glass()
    {
        return View();
    }
    public IActionResult ContactUs()
    {
        //Loops
        for (var i = 0; i < 10; i++)
        {
            
        }

        while (true)
        {
            
        }

        do
        {
            
        } while (true);

        int n = 10;
        int totalprice = default;
        foreach (var item in n)
        {
            int sumitem = item.count + item.price;
            totalprice += sumitem;
        }





        //show output with viewbag in ContactUs page

        ViewBag.nfnc4 = namefnc4(10 , 20);

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

    //Function in C#

    void namefnc1(){
        // Not input
        int a = 1;
        int b = 2;
        string str = a+b.ToString(); 
    }
    void namefnc3(int a , int b){
        // void but has input
        String c = a + b.ToString() ;
    }
    string namefnc2(){
        // Not input but has output
        int a = 10;
        int b = 20;
        return (a + b).ToString() ;
    }
    string namefnc4(int a , int b){
        //has input and has output
        return (a + b).ToString();
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
