using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/venda")]
    public class VendaController : ControllerBase
    {
        private readonly DataContext _context;
        public VendaController(DataContext context)
        {
            _context = context;
        }

    [HttpPost]
    [Route("create")]
    public  IActionResult Cadastrar([FromBody] Venda venda){

      // CADASTRA VENDA
     /*  venda.Itens = _context.Vendas.Find(venda.Itens); */
      _context.Vendas.Add(venda);
      _context.SaveChanges();
      return Created("", venda);

    }


        //GET: api/venda/list
        //ALTERAR O MÉTODO PARA MOSTRAR TODOS OS DADOS DA VENDA E OS DADOS RELACIONADOS
        [HttpGet]
        [Route("list")]
        public IActionResult List() =>
            Ok(_context.Vendas
            .Include(p => p.Itens)
            /* .Include(q => q.Cliente)
            .Include(r => r.PagamentoId)
            .Include(s => s.VendaId)
            .Include(t => t.CriadoEm) */
            .ToList());
    }
}  