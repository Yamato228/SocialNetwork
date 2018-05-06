
using SocialNetwork.Models;
using SocialNetwork.ViewModel.Account;
using System.Web.Mvc;
using System.Web.Security;

namespace SocialNetwork.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (AuthLogic.CanAuthenticate(model.Login, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.Login, false);
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Bad login/password");
            return View(model);
        }

        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("~");
        }
    }
}