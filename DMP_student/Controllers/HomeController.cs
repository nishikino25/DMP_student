using DMP_student.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Json;

namespace DMP_student.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
        public IActionResult QueryApplication()
        {
            return View();
        }
        public IActionResult QueryStatus()
        {
            return View();
        }
        public IActionResult SequenceChoice()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*public ActionResult Upload(List<HttpPostedFileBase> files) //單一檔案參數 HttpPostedFileBase file
        {
            //單一檔案
            //if (file != null)
            //{
            //    if (file.ContentLength > 0)
            //    {
            //        string path = Path.Combine(Server.MapPath("~/FileUploads/"));
            //        if (!Directory.Exists(path))
            //        {
            //            Directory.CreateDirectory(path);
            //        }

            //        var fileName = Path.GetFileName(file.FileName);
            //        file.SaveAs(path + fileName);
            //    }
            //}

            string message = "";

            //多檔案
            if (files != null)
            {
                if (files.Count > 0)
                {
                    //path 看要不要再串接 學號 + 單號
                    string path = Path.Combine(Server.MapPath("~/FileUploads/"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    foreach (HttpPostedFileBase file in files)
                    {
                        string fileName = Path.GetFileName(file.FileName);
                        file.SaveAs(path + fileName);
                    }
                }
            }

            string serverMessage = JsonContent.SerializeObject(message);
            return Json(new { serverMessage }, JsonRequestBehavior.AllowGet);
        }
        */

    }

}