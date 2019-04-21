using StockBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SystemRefactored.Controllers
{
    public class HomeController : Controller
    {
        UserManage userManage;
        public HomeController()
        {
            this.userManage = new UserManage();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult CheckAdmin()
        {
            //bool IsOfNot = userManage.IsAdmin(将获取的数据转换成对应的格式);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}