using System.Web.Http;
using System.Web.Http.Cors;
using AspnetWebApi.Interfaces;
using AspnetWebApi.Services;

namespace AspnetWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OperadorasController : ApiController
    {
        private IOperadorasService service = ServicesFactory.GetOperadorasService();

        public object Get()
        {
            return this.Json(this.service.GetOperadoras());
        }

        public object Get(int id)
        {
            return this.Json(this.service.GetOperadora(id));
        }
    }
}
