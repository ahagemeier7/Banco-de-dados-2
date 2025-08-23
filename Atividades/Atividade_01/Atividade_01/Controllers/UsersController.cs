using Atividade_01.Data;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_01.Controllers
{
    public class UsersController : Controller
    {
        private readonly CompanyContext _context;

        public UsersController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
    }
}
