using Atividade_01.Data;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_01.Controllers
{
    public class AddressController : Controller
    {
        private readonly CompanyContext _context;

        public AddressController(CompanyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Addresses.ToList());
        }
    }
}
