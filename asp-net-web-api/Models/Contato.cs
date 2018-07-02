namespace AspnetWebApi.Models
{
    using System;

    /// <summary>
    /// Represents Contato
    /// </summary>
    public class Contato
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contato" /> class.
        /// </summary>
        public Contato()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contato" /> class.
        /// </summary>
        /// <param name="serial">Número Serial</param>
        /// <param name="nome">Nome do Contato</param>
        /// <param name="telefone">Telefone do Contato</param>
        /// <param name="data">Data de criação</param>
        /// <param name="operadora">Operadora do Contato</param>
        public Contato(int serial, string nome, string telefone, DateTime data, Operadora operadora)
        {
            this.serial = serial;
            this.nome = nome;
            this.telefone = telefone;
            this.data = data;
            this.operadora = operadora;
        }
        
        /// <summary>
        /// Gets or sets Serial number
        /// </summary>
        public int serial { get; set; }

        /// <summary>
        /// Gets or sets Nome do Contato
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// Gets or sets Telefone do Contato
        /// </summary>
        public string telefone { get; set; }

        /// <summary>
        /// Gets or sets Data de Cadastro
        /// </summary>
        public DateTime data { get; set; }

        /// <summary>
        /// Gets or sets Operadora do Contato
        /// </summary>
        public Operadora operadora { get; set; }
    }
}