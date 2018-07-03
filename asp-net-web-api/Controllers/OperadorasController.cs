using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using AspnetWebApi.Interfaces;
using AspnetWebApi.Models;
using AspnetWebApi.Services;

namespace AspnetWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OperadorasController : ApiController
    {
        private IOperadorasService service = ServicesFactory.GetOperadorasService();

        public IEnumerable<Operadora> Get()
        {
            return this.service.GetOperadoras();
        }

        public Operadora Get(int id)
        {
            return this.service.GetOperadora(id);
        }
    }
}
