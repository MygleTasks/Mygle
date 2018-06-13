using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Venda
    {
        public long Id { get; set; }
        public string Categoria { get; set; }
        public Decimal Quantidade { get; set; }
        public Decimal ValorUnitario { get; set; }
        public DateTime Data { get; set; }
        
        public Decimal ValorTotal()
        {
            return Quantidade * ValorUnitario;
        }
    }
}
