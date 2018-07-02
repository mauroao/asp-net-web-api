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
        private IOperadorasService service = ServicesFactory.GetOperadorasService();

        // GET: api/Operadoras
        public IEnumerable<Operadora> Get()
        {
            return this.service.GetOperadoras();
        }

        // GET: api/Operadoras/5
        public Operadora Get(int id)
        {
            return this.service.GetOperadora(id);
        }
    }
}
