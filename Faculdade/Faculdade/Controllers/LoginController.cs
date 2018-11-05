using Faculdade.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using System.Web.Security;

namespace Faculdade.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private rentacarEntities rentacar = new rentacarEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Users user)
        {
            if (!ModelState.IsValid)
                return View();
            user.password = string.Join("", SHA1CryptoServiceProvider.Create().ComputeHash(Encoding.UTF8.GetBytes(user.password)).SelectMany(x => x.ToString("x2")));
            var doLogin = rentacar.Users.Where(model => model.register == user.register && model.password == user.password).FirstOrDefault();

            if (doLogin != null)
            {
                FormsAuthentication.SetAuthCookie(doLogin.name, false);

                if (Request.QueryString["ReturnUrl"] == null)
                    return RedirectToAction("", "Home");
                else
                    return RedirectToAction(Request.QueryString["ReturnUrl"].ToString());
            }
            else
            {
                ModelState.AddModelError("", "Usuário e ou senha inválido!");
            }

            return View(user);
        }
    }
}