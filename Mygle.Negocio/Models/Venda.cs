using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Venda
    {
        public virtual long Id { get; set; }
        public virtual string Categoria { get; set; }
        public virtual Decimal Quantidade { get; set; }
        public virtual Decimal ValorUnitario { get; set; }
        public virtual DateTime Data { get; set; }
        
        public Decimal ValorTotal
        {
            get
            {
                return Quantidade * ValorUnitario;
            }
        }

        public Venda()
        {
            this.Data = DateTime.Now;
        }
    }
}
