using FORUM_WEB_2._0.Models;
using FORUM_WEB_2._0.Models.FrameWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FORUM_WEB_2._0.Controllers
{
    public class ReportPageController : Controller
    {
        // GET: ReportPage
        public ActionResult ReportPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ReportPage(ReportModel model)
        {
            if (ModelState.IsValid)
            {
                Models.FrameWorks.FORUM_WEB_V2Entities db = new Models.FrameWorks.FORUM_WEB_V2Entities();
                var session = (UserLogin)Session[FORUM_WEB_2._0.Common.CommonSession.USER_LOGIN];
                var rp = new BaoCao()
                {
                    NoiDung = model.NoiDung,
                    NguoiBaoCao = session.TenDangNhap
                };
                db.BaoCao.Add(rp);
                db.SaveChanges();
                return RedirectToAction("ReportNoti", "ReportPage");
            }
            return View();
        }
        public ActionResult ReportNoti()
        {
            return View();
        }
    }
}