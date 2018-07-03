using System;
using System.Collections.Generic;
using AspnetWebApi.Models;

namespace AspnetWebApi.DataBase
{
    public class MockDatabase
    {
        private static MockDatabase instance = null;

        private List<Contato> contatos = null;

        private List<Operadora> operadoras = null;

        private MockDatabase()
        {
        }

        public static MockDatabase GetInstance()
        {
            if (instance == null)
            {
                instance = new MockDatabase();
            }

            return instance;
        }

        public List<Contato> GetContatos()
        {
            var listaOperadoras = this.GetOperadoras();

            if (this.contatos == null)
            {
                this.contatos = new List<Contato>()
                {
                    new Contato(123456, "Pedro", "9999-8888", DateTime.Today, listaOperadoras[0]),
                    new Contato(234567, "Ana", "9999-8877", DateTime.Today, listaOperadoras[1]),
                    new Contato(891234, "Maria", "9999-8866", DateTime.Today, listaOperadoras[2]),
                    new Contato(923450, "Antonio .NET", "9999-2888", DateTime.Today, listaOperadoras[3]),
                    new Contato(934560, "Anada Microsoft", "9999-8872", DateTime.Today, listaOperadoras[0]),
                    new Contato(991230, "Rubens C#", "9999-8826", DateTime.Today, listaOperadoras[0]),
                    new Contato(553456, "Pedro 2", "9999-8888", DateTime.Today, listaOperadoras[0]),
                    new Contato(554567, "Ana 2", "9999-8877", DateTime.Today, listaOperadoras[1]),
                    new Contato(551234, "Maria 2", "9999-8866", DateTime.Today, listaOperadoras[2]),
                    new Contato(553450, "Antonio 2 .NET", "9999-2888", DateTime.Today, listaOperadoras[3]),
                    new Contato(554560, "Anada Microsoft 2", "9999-8872", DateTime.Today, listaOperadoras[0]),
                    new Contato(551230, "Rubens C# 2", "9999-8826", DateTime.Today, listaOperadoras[0])
                };
            }

            return this.contatos;
        }
        
        public List<Operadora> GetOperadoras()
        {
            if (this.operadoras == null)
            {
                this.operadoras = new List<Operadora>()
                {
                    new Operadora("Oi", 14, "Celular", 2.0),
                    new Operadora("Tim", 15, "Celular", 2.1),
                    new Operadora("Vivo", 41, "Celular", 2.2),
                    new Operadora("GVT", 25, "Fixo", 2.3),
                    new Operadora("Embratel", 21, "Fixo", 2.4)
                };
            }

            return this.operadoras;
        }
    }
}