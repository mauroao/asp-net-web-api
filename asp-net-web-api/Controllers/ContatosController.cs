using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using AspnetWebApi.Interfaces;
using AspnetWebApi.Models;
using AspnetWebApi.Services;

namespace AspnetWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ContatosController : ApiController
    {
        private IContatosService service = ServicesFactory.GetContatosService();

        public object Get(int pagenumber = 0, int limit = 0, string findname = "") 
        {
            return this.Json(this.service.GetContatos(pagenumber, limit, findname));
        }

        public Contato Get(int id)
        {
            var item = this.service.GetContato(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            
             return item; 
        }
        
        [HttpPost]
        public void Post([FromBody]Contato contato)
        {
            this.service.AddContato(contato);
        }

        [HttpDelete]
        public object Delete(int id)
        {
            bool deleted = this.service.RemoveContato(id);
            
            return this.Json(new { deleted = deleted });
        }
    }
}