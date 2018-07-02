namespace AspnetWebApi.Models
{
    /// <summary>
    /// Represents an Operadora
    /// </summary>
    public class Operadora
    {
        public Operadora(string nome, int codigo, string categoria, double preco)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.categoria = categoria;
            this.preco = preco;
        }

        public Operadora()
        {
        }

        /// <summary>
        /// Gets or sets Nome da Operadora
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// Gets or sets Codigo da Operadora
        /// </summary>
        public int codigo { get; set; }

        /// <summary>
        /// Gets or sets  Categoria da Operadora
        /// </summary>
        public string categoria { get; set; }

        /// <summary>
        /// Gets or sets  Preço do Minuto
        /// </summary>
        public double preco { get; set; }
    }
}