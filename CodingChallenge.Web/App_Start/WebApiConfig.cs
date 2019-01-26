using System;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace CodingChallenge.Web
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API configuration and services
      GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
          new System.Net.Http.Formatting.RequestHeaderMapping("Accept", "text/html", StringComparison.InvariantCultureIgnoreCase, true, "application/json")
      );

      // Use camel case for JSON data
      config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

      // Web API routes
      config.MapHttpAttributeRoutes();

      // Convention-based routing.
      config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
    }
  }
}
