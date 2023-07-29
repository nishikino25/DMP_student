using DMP_student.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json.Serialization;

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

        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Dashboard2()
        {
            return View();
        }


        public ActionResult SearchAll()
        {
            string message = "";
            List<Announcement> result = new List<Announcement>();

            try
            {
                Announcement a = new Announcement();
                a.Content = "test";
                a.Href = "https://google.com.tw";
                a.Content = "sfdsfs";
                result.Add(a);
                //result = AnnouncementSettingService.SearchAll();
            }
            catch (Exception exception)
            {
            }

            string serverModel = JsonConvert.SerializeObject(result);
            string serverMessage = JsonConvert.SerializeObject(message);
            return Json(new { serverModel, serverMessage }, System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult QueryStudentInfo()
        {
            StudentInfo result = new StudentInfo();
            string message = "";
            try
            {
                StudentInfo s = new StudentInfo
                {
                    StuName = "DDDD",
                    StudentId = "AAAA",
                    Department = "WEQEQ"
                };
                //stustatus = studentService.GetStuStatu(userId);
                //result.StuName = stustatus.StudentName;
                //result.StudentId = stustatus.StudentNo;
                //result.Department = stustatus.Department;
                result = s;
            }
            catch (Exception exception)
            {
                message = "公告頁-學生資訊失敗";
            }

            string serverModel = JsonConvert.SerializeObject(result);
            string serverMessage = JsonConvert.SerializeObject(message);
            return Json(new { serverModel, serverMessage }, System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

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
public partial class Announcement
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Href { get; set; }
    public string CreateUserID { get; set; }
    public System.DateTime CreateDateTime { get; set; }
    public bool IsInvalid { get; set; }
}
public class StudentInfo
{
    public string StuName { get; set; }
    public string StudentId { get; set; }
    public string EducationalSystem { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public string ContactPhone { get; set; }
}