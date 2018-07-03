namespace AspnetWebApi
{
    using System.Web.Http;

    /// <summary>
    /// WebApiApplication class
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
