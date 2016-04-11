using Microsoft.AspNet.Mvc;

namespace MyFollow.Controllers
{
    /// <summary>
    /// Default Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Default Index Action
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
