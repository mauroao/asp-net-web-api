using asp_net_web_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_net_web_api.DataBase
{
    public class Database
    {
        private static Database instance = null;
        public static Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Database();
            }
            return instance;
        }

        private Database() { }

        private List<Contato> contatos = null;
        private List<Operadora> operadoras = null;

        public List<Contato> getContatos()
        {
            var listaOperadoras = this.getOperadoras();

            if (contatos == null)
            {
                contatos = new List<Contato>();
                contatos.Add(new Contato(123456, "Pedro", "9999-8888", DateTime.Today, listaOperadoras[0]));
                contatos.Add(new Contato(234567, "Ana", "9999-8877", DateTime.Today, listaOperadoras[1]));
                contatos.Add(new Contato(891234, "Maria", "9999-8866", DateTime.Today, listaOperadoras[2]));
                contatos.Add(new Contato(923450, "Antonio .NET", "9999-2888", DateTime.Today, listaOperadoras[3]));
                contatos.Add(new Contato(934560, "Anada Microsoft", "9999-8872", DateTime.Today, listaOperadoras[0]));
                contatos.Add(new Contato(991230, "Rubens C#", "9999-8826", DateTime.Today, listaOperadoras[0]));
            }

            return contatos;
        }

        public List<Operadora> getOperadoras()
        {
            if (operadoras == null)
            {
                operadoras = new List<Operadora>() {
                    new Operadora("Oi", 14, "Celular", 2.0),
                    new Operadora("Tim", 15, "Celular", 2.1),
                    new Operadora("Vivo", 41, "Celular", 2.2),
                    new Operadora("GVT", 25, "Fixo", 2.3),
                    new Operadora("Embratel", 21, "Fixo", 2.4)
                };
            }

            return operadoras;
        }
    }
}