using asp_net_web_api.DataBase;
using asp_net_web_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_net_web_api.Services
{
    public class OperadorasService
    {
        public List<Operadora> getOperadoras()
        {
            return Database.GetInstance().getOperadoras();
        }

        public Operadora getOperadora(int codigo)
        {
            return this.getOperadoras().FirstOrDefault(n => n.codigo == codigo);
        }
    }
}