using System;
using System.Linq;
using AspnetWebApi.DataBase;
using AspnetWebApi.Interfaces;
using AspnetWebApi.Models;

namespace AspnetWebApi.Services
{
    public class ContatosMockService : IContatosService
    {
        public PaginatedContatos GetContatos(int pagenumber = 0, int limit = 0, string findname = "")
        {
            if (pagenumber == 0 || limit == 0)
            {
                return new PaginatedContatos()
                {
                    TotalCount = MockDatabase.GetInstance().GetContatos().Count,
                    PaginatedData = MockDatabase.GetInstance().GetContatos(),
                    PageNumber = 1,
                    TotalPages = 1
                };
            }
            
            var paginatedData = MockDatabase
                .GetInstance()
                .GetContatos();

            if (!string.IsNullOrEmpty(findname))
            {
                paginatedData = paginatedData.Where(contato => contato.Nome.Contains(findname)).ToList();
            }

            paginatedData = paginatedData
                .OrderBy(contato => contato.Nome)
                .Skip((pagenumber - 1) * limit)
                .Take(limit)
                .ToList();

            return new PaginatedContatos()
            {
                TotalCount = MockDatabase.GetInstance().GetContatos().Count,
                PaginatedData = paginatedData,
                PageNumber = pagenumber,
                TotalPages = (int)Math.Ceiling((double)MockDatabase.GetInstance().GetContatos().Count / (double)limit)
            };         
        }

        public Contato GetContato(int serial)
        {
            return this.GetContatos().PaginatedData.FirstOrDefault(n => n.Serial == serial);
        }

        public void AddContato(Contato contato)
        {
            this.GetContatos().PaginatedData.Add(contato);
        }

        public bool RemoveContato(int serial)
        {
            var contato = this.GetContato(serial);

            if (contato == null)
            {
                return false;
            }

            this.GetContatos().PaginatedData.Remove(contato);

            return true;
        }
    }
}