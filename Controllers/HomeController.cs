using System.Net.Http.Headers;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using server_side.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace server_side.Controllers;

public class HomeController : Controller
{

    private readonly Context DB;
    private readonly IWebHostEnvironment webHostEnvironment;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,Context context,IWebHostEnvironment webHostEnvironment)
    {
        IWebHostEnvironment webHostEnvironment1;
        DB = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Users()
    {
            Users prs1 = new Users();
            prs1.Name = "amir";
            prs1.Family = "ghahremani";
            prs1.Fathername = "ali";
            prs1.Password = "123456";
            prs1.Birthday = DateTime.Parse("1990/12/23");
            prs1.Gender = true;//true: man False: woman
            prs1.Active = true;
            DB.Userss.Add(prs1);
            DB.SaveChanges();

            Users prs2 = new Users();
            prs2.Name = "mohammad";
            prs2.Family = "rezaee";
            prs2.Fathername = "reza";
            prs2.Password = "123";
            prs2.Birthday = DateTime.Parse("1991/12/23");
            prs2.Gender = true;//true: man False: woman
            prs2.Active = false;
            DB.Userss.Add(prs2);
            DB.SaveChanges();

            Users prs3 = new Users();
            prs3.Name = "ali";
            prs3.Family = "kamali";
            prs3.Fathername = "omid";
            prs3.Password = "456";
            prs3.Birthday = DateTime.Parse("2002/11/10");
            prs3.Gender = true;//true: man False: woman
            prs3.Active = true;
            DB.Userss.Add(prs3);
            DB.SaveChanges();

            var query = DB.Userss.ToList();
        return View(query);
    }

    public IActionResult Tar()
    {
        return View();
    }

    
    public IActionResult Tombak()
        {
            return View();
        }
    

    public IActionResult Daf()
    {
        return View();
    }

    public IActionResult SavePro(Product prd)
    {
        #region upload
        string Unique_Fname = Guid.NewGuid() + prd.Img.FileName;
        string uploadfolder = Path.Combine(webHostEnvironment.WebRootPath,Unique_Fname);
        using(FileStream FS = new FileStream(uploadfolder, FileMode.Create))
        {
            prd.Img.CopyTo(FS);
        }
        #endregion
        
        #region save-to-db
        prd.Imgpath = Unique_Fname;
        DB.productss.Add(prd);
        DB.SaveChanges();
        #endregion
        
        
        return RedirectToAction("index");
    }

    public IActionResult Pro(Product prd01)
    {
        //INSERT
            //Product prd1 = new Product();
            //prd1.Name = "tombak - shirani Isfahan";
            //prd1.Description = "3 Sign";
            //prd1.Available = true;
            //prd1.Price = 330;
            //DB.productss.Add(prd1);
            //DB.SaveChanges();

            //Product prd2 = new Product();
            //prd2.Name = "santoor";
            //prd2.Description = "2 Sign";
            //prd2.Available = true;
            //prd2.Price = 560;
            //DB.productss.Add(prd2);
            //DB.SaveChanges();

            //Product prd3 = new Product();
            //prd3.Name = "daf - ahmadi";
            //prd3.Description = "1 Sign";
            //prd3.Available = true;
            //prd3.Price = 280;
            //DB.productss.Add(prd3);
            //DB.SaveChanges();

            //Product prd4 = new Product();
            //prd4.Name = "kakhen";
            //prd4.Description = "yamaha";
            //prd4.Available = true;
            //prd4.Price = 490.5f;
            //DB.productss.Add(prd4);
            //DB.SaveChanges();
            //INSERT

            //SELECT
            var query = DB.productss.ToList().OrderByDescending(x => x.Id);//.Tolist() , .count() , ||
                                           //Link Lambda command^^^^^^^^^^^ 
            //var query = DB.productss.Where(x => x.Available ==true && x.Price >= 400).ToList();
            var queryCP = DB.productss.ToList().Count;
            //SELECT

        ViewBag.CP = queryCP;

        return View(query);
    }


    public IActionResult Basket()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
