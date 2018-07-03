using System.Runtime.Serialization;

namespace AspnetWebApi.Models
{
    [DataContract]
    public class Operadora
    {
        public Operadora(string nome, int codigo, string categoria, double preco)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Categoria = categoria;
            this.Preco = preco;
        }

        public Operadora()
        {
        }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "codigo")]
        public int Codigo { get; set; }

        [DataMember(Name = "categoria")]
        public string Categoria { get; set; }

        [DataMember(Name = "preco")]
        public double Preco { get; set; }
    }
}