using System;
using System.Configuration;
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
                string className = ConfigurationManager.AppSettings[contatosServiceClassNameParam];
                contatosService = (IContatosService)Activator.CreateInstance(Type.GetType(className));
            }

            return contatosService;
        }

        public static IOperadorasService GetOperadorasService()
        {
            if (operadorasService == null)
            {
                var className = ConfigurationManager.AppSettings[operadorasServiceClassNameParam];
                operadorasService = (IOperadorasService)Activator.CreateInstance(Type.GetType(className));
            }

            return operadorasService;
        }
    }
}