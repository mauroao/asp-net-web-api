using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_net_web_api.Models
{
    public class Operadora
    {
        public string nome { get; set; }
        public int codigo { get; set; }
        public string categoria { get; set; }
        public double preco { get; set; }
        public Operadora() { }
        public Operadora(string nome, int codigo, string categoria, double preco)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.categoria = categoria;
            this.preco = preco;
        }
    }
}