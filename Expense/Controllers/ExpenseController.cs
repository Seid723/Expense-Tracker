using Microsoft.AspNetCore.Mvc;

namespace Expense.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
