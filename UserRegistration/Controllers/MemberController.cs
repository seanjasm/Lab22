using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace UserRegistration
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CreateUserView model, string returnUrl)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Welcome", routeValues: new { fn = model.FirstName,
                ln=model.LastName, dob=model.Dob, email=model.Email, user=model.UserName, sex=model.Sex });
            }
            return View();
        }

        public ActionResult Welcome(string fn, string ln, string dob, string email, string user, string sex)
        {

            SummaryView summaryView = new SummaryView();

            summaryView.FirstName = fn;
            summaryView.LastName = ln;
            summaryView.Dob = dob;
            summaryView.Email = email;
            summaryView.UserName = user;
            summaryView.Sex = (Gender)Enum.Parse(typeof(Gender), sex);

            //ViewBag.Fn = fn;
            //ViewBag.Ln = ln;
            //ViewBag.dob = dob;
            //ViewBag.email = email;
            //ViewBag.user = user;
            //ViewBag.sex = sex;

            return View(summaryView);
        }

    }
}