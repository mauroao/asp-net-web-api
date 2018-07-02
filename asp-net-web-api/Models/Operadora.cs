namespace AspnetWebApi.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents an Operadora
    /// </summary>
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

        /// <summary>
        /// Gets or sets Nome da Operadora
        /// </summary>
        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Gets or sets Codigo da Operadora
        /// </summary>
        [DataMember(Name = "codigo")]
        public int Codigo { get; set; }

        /// <summary>
        /// Gets or sets  Categoria da Operadora
        /// </summary>
        [DataMember(Name = "categoria")]
        public string Categoria { get; set; }

        /// <summary>
        /// Gets or sets  Preço do Minuto
        /// </summary>
        [DataMember(Name = "preco")]
        public double Preco { get; set; }
    }
}