namespace AspnetWebApi.Services
{
    using System;
    using System.Web.Configuration;
    using AspnetWebApi.Interfaces;

    /// <summary>
    /// ServicesFactory class
    /// </summary>
    public static class ServicesFactory
    {
        private static IContatosService iContatosService;
        private static IOperadorasService iOperadorasService;
        private static string contatosServiceClassNameParam = "ContatosServiceClassName";
        private static string operadorasServiceClassNameParam = "OperadorasServiceClassName";

        public static IContatosService GetContatosService()
        {
            if (iContatosService == null)
            {
                string className = WebConfigurationManager.AppSettings[contatosServiceClassNameParam];
                iContatosService = (IContatosService)Activator.CreateInstance(Type.GetType(className));
            }

            return iContatosService;
        }

        public static IOperadorasService GetOperadorasService()
        {
            if (iOperadorasService == null)
            {
                var className = WebConfigurationManager.AppSettings[operadorasServiceClassNameParam];
                iOperadorasService = (IOperadorasService)Activator.CreateInstance(Type.GetType(className));
            }

            return iOperadorasService;
        }
    }
}