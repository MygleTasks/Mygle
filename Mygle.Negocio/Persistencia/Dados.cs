using Mygle.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Persistencia
{
    public class Dados
    {
        //Pacote de listas que são salvas no XML
        public List<Usuario> Usuarios;
        public List<Venda> Vendas;
        public List<Categoria> Categorias;
    }
}
