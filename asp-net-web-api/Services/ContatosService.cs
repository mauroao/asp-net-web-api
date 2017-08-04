using asp_net_web_api.DataBase;
using asp_net_web_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_net_web_api.Services
{
    public class ContatosService
    {
        public List<Contato> getContatos()
        {
            return Database.GetInstance().getContatos();
        }

        public Contato getContato(int serial)
        {
            return this.getContatos().FirstOrDefault(n => n.serial == serial);
        }

        public void addContato(Contato contato)
        {
            this.getContatos().Add(contato);
        }

        public bool removeContato(int serial)
        {
            var contato = this.getContato(serial);

            if (contato == null)
            {
                return false;
            }

            this.getContatos().Remove(contato);

            return true;
        }
    }
}