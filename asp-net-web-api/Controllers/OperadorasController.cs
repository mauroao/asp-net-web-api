namespace AspnetWebApi.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using AspnetWebApi.Interfaces;
    using AspnetWebApi.Models;
    using AspnetWebApi.Services;

    /// <summary>
    /// OperadorasController class
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OperadorasController : ApiController
    {
        /// <summary>
        /// Service provider
        /// </summary>
        private IOperadorasService service = ServicesFactory.GetOperadorasService();

        /// <summary>
        /// GET: api/Operadoras
        /// </summary>
        /// <returns>Returns a list of Operadoras</returns>
        public IEnumerable<Operadora> Get()
        {
            return this.service.GetOperadoras();
        }

        /// <summary>
        /// GET: api/Operadoras/5
        /// </summary>
        /// <param name="id">Operadora ID</param>
        /// <returns>Returns an Operadora</returns>
        public Operadora Get(int id)
        {
            return this.service.GetOperadora(id);
        }
    }
}
