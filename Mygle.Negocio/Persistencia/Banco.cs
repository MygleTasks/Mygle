using Mygle.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mygle.Negocio.Persistencia
{
    public class Banco : DbContext
    {

        //Criação das listas que armazenam os usuários, as vendas e as categorias dentro do banco
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
    }
}
