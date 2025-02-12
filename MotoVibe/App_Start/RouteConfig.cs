using System.Web.Mvc;
using System.Web.Routing;

public class RouteConfig
{
    public static void RegisterRoutes(RouteCollection routes)
    {
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        // Mapping routes with dynamic parameters (productId, blogId)
        routes.MapRoute(
            name: "ProductDetails",
            url: "Home/Detailproduct/{productId}",
            defaults: new { controller = "Home", action = "Detailproduct", productId = UrlParameter.Optional }
        );

        routes.MapRoute(
            name: "BlogDetails",
            url: "Home/detaiblog/{blogId}",
            defaults: new { controller = "Home", action = "detaiblog", blogId = UrlParameter.Optional }
        );

        // Default route
        routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
        );
    }
}
