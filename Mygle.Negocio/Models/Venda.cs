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
        public virtual Double Quantidade { get; set; }
        public virtual Double ValorUnitario { get; set; }
        public virtual DateTime Data { get; set; }
        
        public Double ValorTotal
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
