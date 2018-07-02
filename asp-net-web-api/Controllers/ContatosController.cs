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
        /// <summary>
        /// Service Provider
        /// </summary>
        private IContatosService service = ServicesFactory.GetContatosService();

        /// <summary>
        /// GET: api/Contatos
        /// </summary>
        /// <param name="pagenumber">Number of page</param>
        /// <param name="limit">Rows per page</param>
        /// <param name="findname">Query search name</param>
        /// <returns>Returns a Contato list</returns>
        public IEnumerable<Contato> Get(int pagenumber, int limit, string findname) 
        {
            return this.service.GetContatos();
        }

        /// <summary>
        /// GET: api/Contatos/5
        /// </summary>
        /// <param name="id">Id number</param>
        /// <returns>Returns a Contato</returns>
        public Contato Get(int id)
        {
            var item = this.service.GetContato(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            
             return item; 
        }
        
        /// <summary>
        /// POST: api/Contatos
        /// </summary>
        /// <param name="contato">Contato object to be sabed</param>
        [HttpPost]
        public void Post([FromBody]Contato contato)
        {
            this.service.AddContato(contato);
        }

        /// <summary>
        /// DELETE: api/Contatos/5
        /// </summary>
        /// <param name="id">ID of Contato to be deleted</param>
        /// <returns>Returns information about sucessful deletion</returns>
        [HttpDelete]
        public object Delete(int id)
        {
            bool deleted = this.service.RemoveContato(id);
            
            return this.Json(new { deleted = deleted });
        }
    }
}
