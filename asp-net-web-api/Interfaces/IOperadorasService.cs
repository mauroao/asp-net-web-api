namespace AspnetWebApi.Interfaces
{
    using System.Collections.Generic;
    using AspnetWebApi.Models;

    public interface IOperadorasService
    {
        IList<Operadora> GetOperadoras();

        Operadora GetOperadora(int codigo);
    }
}