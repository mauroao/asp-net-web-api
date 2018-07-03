using System.Collections.Generic;
using AspnetWebApi.Models;

namespace AspnetWebApi.Interfaces
{
    public interface IContatosService
    {
        PaginatedContatos GetContatos(int pagenumber = 0, int limit = 0, string findname = "");

        Contato GetContato(int serial);

        void AddContato(Contato contato);

        bool RemoveContato(int serial);
    }
}