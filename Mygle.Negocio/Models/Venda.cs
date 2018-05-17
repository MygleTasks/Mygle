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
        public string nome { get; set; }
        public int quantidade { get; set; }
        public double valUnit { get; set; }
        public double valTotal { get; set; }
        public DateTime data { get; set; }

    }
}
