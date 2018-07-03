using System;
using System.Runtime.Serialization;

namespace AspnetWebApi.Models
{
    [DataContract]
    public class Contato
    {
        public Contato()
        {
        }

        public Contato(int serial, string nome, string telefone, DateTime data, Operadora operadora)
        {
            this.Serial = serial;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Data = data;
            this.Operadora = operadora;
        }

        [DataMember(Name = "serial")]
        public int Serial { get; set; }

        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [DataMember(Name = "telefone")]
        public string Telefone { get; set; }

        [DataMember(Name = "data")]
        public DateTime Data { get; set; }

        [DataMember(Name = "operadora")]
        public Operadora Operadora { get; set; }
    }
}