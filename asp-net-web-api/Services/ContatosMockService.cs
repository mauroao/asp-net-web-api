using System.Collections.Generic;
using System.Linq;
using AspnetWebApi.DataBase;
using AspnetWebApi.Interfaces;
using AspnetWebApi.Models;

namespace AspnetWebApi.Services
{
    public class ContatosMockService : IContatosService
    {
        public IList<Contato> GetContatos(int pagenumber = 0, int limit = 0, string findname = "")
        {
            return MockDatabase.GetInstance().GetContatos();
        }

        public Contato GetContato(int serial)
        {
            return this.GetContatos().FirstOrDefault(n => n.Serial == serial);
        }

        public void AddContato(Contato contato)
        {
            this.GetContatos().Add(contato);
        }

        public bool RemoveContato(int serial)
        {
            var contato = this.GetContato(serial);

            if (contato == null)
            {
                return false;
            }

            this.GetContatos().Remove(contato);

            return true;
        }
    }
}