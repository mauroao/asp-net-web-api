using System;
using System.Web.Configuration;
using AspnetWebApi.Interfaces;

namespace AspnetWebApi.Services
{
    public static class ServicesFactory
    {
        private static IContatosService contatosService;
        private static IOperadorasService operadorasService;
        private static string contatosServiceClassNameParam = "ContatosServiceClassName";
        private static string operadorasServiceClassNameParam = "OperadorasServiceClassName";

        public static IContatosService GetContatosService()
        {
            if (contatosService == null)
            {
                string className = WebConfigurationManager.AppSettings[contatosServiceClassNameParam];
                contatosService = (IContatosService)Activator.CreateInstance(Type.GetType(className));
            }

            return contatosService;
        }

        public static IOperadorasService GetOperadorasService()
        {
            if (operadorasService == null)
            {
                var className = WebConfigurationManager.AppSettings[operadorasServiceClassNameParam];
                operadorasService = (IOperadorasService)Activator.CreateInstance(Type.GetType(className));
            }

            return operadorasService;
        }
    }
}