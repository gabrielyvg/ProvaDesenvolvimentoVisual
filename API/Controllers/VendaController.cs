using System.Linq;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult List()
        {
            return Ok(_context.Vendas.ToList());
        }
    }
}  