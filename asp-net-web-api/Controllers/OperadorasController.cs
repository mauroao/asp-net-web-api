using asp_net_web_api.Models;
using asp_net_web_api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace asp_net_web_api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OperadorasController : ApiController
    {
        private OperadorasService service = new OperadorasService();

        // GET: api/Operadoras
        public IEnumerable<Operadora> Get()
        {
            return service.getOperadoras();
        }

        // GET: api/Operadoras/5
        public Operadora Get(int id)
        {
            return service.getOperadora(id);
        }

    }
}
