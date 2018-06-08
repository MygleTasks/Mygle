using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }

        public string Descrever()
        {
            return string.Format($"ID: {this.Id}\nNome: {this.nome}\nMatricula: {this.matricula}");
        }
    }
}
