using asp_net_web_api.Models;
using asp_net_web_api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace asp_net_web_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ContatosController : ApiController
    {
        private ContatosService service = new ContatosService();

        // GET: api/Contatos
        public IEnumerable<Contato> Get()
        {
            return service.getContatos();
        }

        // GET: api/Contatos/5
        public Contato Get(int id)
        {
            var item = service.getContato(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            
             return item; 
        }

        // POST: api/Contatos
        [HttpPost]
        public void Post([FromBody]Contato contato)
        {
            service.addContato(contato);
        }

        // DELETE: api/Contatos/5
        [HttpDelete]
        public Object Delete(int id)
        {
            bool deleted = service.removeContato(id);
            
            return Json(new { deleted = deleted });
        }
    }
}
