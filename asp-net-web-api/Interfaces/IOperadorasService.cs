using System.Collections.Generic;
using AspnetWebApi.Models;

namespace AspnetWebApi.Interfaces
{
    public interface IOperadorasService
    {
        IList<Operadora> GetOperadoras();

        Operadora GetOperadora(int codigo);
    }
}