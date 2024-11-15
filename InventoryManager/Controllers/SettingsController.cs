using Microsoft.AspNetCore.Mvc;

namespace InventoryManager.UI.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
