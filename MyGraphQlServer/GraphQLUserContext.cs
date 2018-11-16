using System.Security.Claims;

namespace MyGraphQlServer
{
    public class GraphQlUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}
