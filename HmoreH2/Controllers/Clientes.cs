using HmoreH2.Data;
using Microsoft.AspNetCore.Mvc;

namespace HmoreH2.Controllers
{
    public class Clientes : Controller
    {
        private readonly credenciaiscontexto _context;//Aqui a Controller ganha acesso ao contexto do banco de dados

        public Clientes( credenciaiscontexto contexto) 
        {
            _context = contexto;
        }

        public async Task<IActionResult> Index()
        {            
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(Clientes cliente)
        {
            if(ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }
    }
}
