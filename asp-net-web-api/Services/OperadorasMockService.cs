using System.Collections.Generic;
using System.Linq;
using AspnetWebApi.DataBase;
using AspnetWebApi.Interfaces;
using AspnetWebApi.Models;

namespace AspnetWebApi.Services
{
    public class OperadorasMockService : IOperadorasService
    {
        public IList<Operadora> GetOperadoras()
        {
            return MockDatabase.GetInstance().GetOperadoras();
        }

        public Operadora GetOperadora(int codigo)
        {
            return this.GetOperadoras().FirstOrDefault(n => n.Codigo == codigo);
        }
    }
}