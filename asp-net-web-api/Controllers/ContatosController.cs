namespace AspnetWebApi.Controllers
{
    using System.Collections.Generic;
    using System.Net;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using AspnetWebApi.Interfaces;
    using AspnetWebApi.Models;
    using AspnetWebApi.Services;

    /// <summary>
    /// ContatosController class
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ContatosController : ApiController
    {
        private IContatosService service = ServicesFactory.GetContatosService();

        // GET: api/Contatos
        public IEnumerable<Contato> Get(int pagenumber, int limit, string findname) 
        {
            return this.service.GetContatos();
        }

        // GET: api/Contatos/5
        public Contato Get(int id)
        {
            var item = this.service.GetContato(id);

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
            this.service.AddContato(contato);
        }

        // DELETE: api/Contatos/5
        [HttpDelete]
        public object Delete(int id)
        {
            bool deleted = this.service.RemoveContato(id);
            
            return this.Json(new { deleted = deleted });
        }
    }
}
