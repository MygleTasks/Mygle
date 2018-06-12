using Mygle.Negocio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mygle.Negocio.Persistencia
{
    public class Banco
    {
        //Criação das listas que armazenam os usuários, as vendas e as categorias dentro do banco
        private String NomeArquivo = "banco.xml";
        public List<Usuario> Usuarios;
        public List<Venda> Vendas;
        public List<Categoria> Categorias;

        //Construtor (inicializa as listas sempre que forem chamadas)
        public Banco()
        {
            this.Usuarios = new List<Usuario>();
            this.Vendas = new List<Venda>();
            this.Categorias = new List<Categoria>();

            this.CarregarDados();
        }

        //Método que salva os dados em XML
        public void SalvarDados()
        {
            Dados dados = new Dados();
            dados.Usuarios = this.Usuarios;
            dados.Vendas = this.Vendas;
            dados.Categorias = this.Categorias;

            StreamWriter arquivo = new StreamWriter(this.NomeArquivo);
            XmlSerializer serializer = new XmlSerializer(typeof(Dados));
            serializer.Serialize(arquivo, dados);
            arquivo.Close();
        }

        //Método que carrega os dados salvos
        public void CarregarDados()
        {
            if (File.Exists(NomeArquivo))
            {
                FileStream arquivo = File.OpenRead(NomeArquivo);
                XmlSerializer serializer = new XmlSerializer(typeof(Dados));
                Dados dados = serializer.Deserialize(arquivo) as Dados;
                this.Usuarios = dados.Usuarios;
                this.Vendas = dados.Vendas;
                this.Categorias = dados.Categorias;
            }
        }
    }
}
