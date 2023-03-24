using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            var settings = new JsonSerializerSettings
            {
                Converters = { new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-ddTHH:mm:ss" } }
            };
            var formatter = new JsonMediaTypeFormatter { SerializerSettings = settings };
            config.Formatters.Clear();
            config.Formatters.Add(formatter);

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
