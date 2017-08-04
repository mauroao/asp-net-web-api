using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_net_web_api.Models
{
    public class Contato
    {
        public int serial { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public DateTime data { get; set; }
        public Operadora operadora { get; set; }
        public Contato() { }
        public Contato(int serial, string nome, string telefone, DateTime data, Operadora operadora)
        {
            this.serial = serial;
            this.nome = nome;
            this.telefone = telefone;
            this.data = data;
            this.operadora = operadora;
        }

    }
}