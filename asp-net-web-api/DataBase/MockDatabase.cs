using System;
using System.Collections.Generic;
using System.IO;
using AspnetWebApi.Models;
using Newtonsoft.Json;

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
                string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/DataBase/Files/contatos.json");
                string json = File.ReadAllText(filePath);
                this.contatos = JsonConvert.DeserializeObject<List<Contato>>(json);
            }

            return this.contatos;
        }
        
        public List<Operadora> GetOperadoras()
        {
            if (this.operadoras == null)
            {
                string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/DataBase/Files/operadoras.json");
                string json = File.ReadAllText(filePath);
                this.operadoras = JsonConvert.DeserializeObject<List<Operadora>>(json);
            }

            return this.operadoras;
        }
    }
}