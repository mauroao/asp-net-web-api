namespace AspnetWebApi.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents Contato
    /// </summary>
    [DataContract]
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
            this.Serial = serial;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Data = data;
            this.Operadora = operadora;
        }

        /// <summary>
        /// Gets or sets Serial number
        /// </summary>
        [DataMember(Name = "serial")]
        public int Serial { get; set; }

        /// <summary>
        /// Gets or sets Nome do Contato
        /// </summary>
        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Gets or sets Telefone do Contato
        /// </summary>
        [DataMember(Name = "telefone")]
        public string Telefone { get; set; }

        /// <summary>
        /// Gets or sets Data de Cadastro
        /// </summary>
        [DataMember(Name = "data")]
        public DateTime Data { get; set; }

        /// <summary>
        /// Gets or sets Operadora do Contato
        /// </summary>
        [DataMember(Name = "operadora")]
        public Operadora Operadora { get; set; }
    }
}