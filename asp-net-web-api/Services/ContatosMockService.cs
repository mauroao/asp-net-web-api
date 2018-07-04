using System;
using System.Collections.Generic;
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
            var paginatedContatos = new PaginatedContatos()
            {
                TotalCount = MockDatabase.GetInstance().GetContatos().Count
            };

            if (pagenumber > 0 && limit > 0)
            {
                var paginatedData = MockDatabase
                    .GetInstance()
                    .GetContatos();

                if (!string.IsNullOrEmpty(findname))
                {
                    paginatedData = paginatedData.Where(contato => contato.Nome.Contains(findname)).ToList();
                }
                
                paginatedContatos.PaginatedData = paginatedData
                    .OrderBy(contato => contato.Nome)
                    .Skip((pagenumber - 1) * limit)
                    .Take(limit)
                    .ToList();
                paginatedContatos.TotalPages = (int)Math.Ceiling((double)paginatedContatos.TotalCount / (double)limit);
                paginatedContatos.PageNumber = pagenumber;
            }
            else
            {
                paginatedContatos.PaginatedData = MockDatabase.GetInstance().GetContatos();
                paginatedContatos.PageNumber = 1;
                paginatedContatos.TotalPages = 1;
            }

            return paginatedContatos;
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