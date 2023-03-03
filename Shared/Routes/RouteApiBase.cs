using System.Data;
namespace RouteApiBase.Shared.Routes;

public class RouteApiBase
{
    public const string API = "/api";
    public int id  { get; set; }

    public const string idParameter = "{id:int}";


}

public class UsuarioRolRouteManager : RouteApiBase
{
    public const string BASE = $"{API}/roles";

    public const string GetByid = $"{BASE}/{idParameter}"; // /api/roles/{id:int} 
    //---> remplazar esto ultimo por el numero que se solicite. // /api/roles/2
    public static string BuildRoute (int id) => GetByid.Replace(idParameter,id.ToString());
}

public class UsuarioRouteManager : RouteApiBase
{
    public const string BASE = $"{API}/users";

        public const string GetByid = $"{BASE}/{idParameter}"; // /api/roles/{id:int} 
    //---> remplazar esto ultimo por el numero que se solicite. // /api/roles/2
    public static string BuildRoute (int id) => GetByid.Replace(idParameter,id.ToString());
}