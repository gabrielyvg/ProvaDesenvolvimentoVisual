using System;

namespace API.Models
{
    public class Pagamento
    {
        //Construtor
        public Pagamento() => CriadoEm = DateTime.Now;
        public int PagamentoId { get; set; }
        public string FormaDePagamento { get; set; }
        public string Cartao { get; set; }
        public string Dinheiro { get; set; }
        public DateTime CriadoEm { get; set; }

    
    }
}