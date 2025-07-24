using Microsoft.AspNetCore.Mvc;

namespace Inspinia.Controllers
{
    public class UsersIgnitionController : Controller
    {
        public IActionResult Users() => PartialView("Users");
        public ActionResult UsersList(string dataSource)
        {
            ViewBag.dataSource = dataSource;
            return PartialView("_UsersList");
        }
     
    }
}