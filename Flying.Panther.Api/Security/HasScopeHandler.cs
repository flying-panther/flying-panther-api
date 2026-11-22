
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Flying.Panther.Api.Security
{
    public class HasScopeHandler : AuthorizationHandler<HasScopeRequirement>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            HasScopeRequirement requirement)
        {
            // Check whether the token has a scope claim
            var scopeClaim = context.User.FindFirst(
                c => c.Type == "scope" &&
                     c.Issuer == requirement.Issuer);

            if (scopeClaim == null)
                return Task.CompletedTask;

            // Split the scopes string into an array
            var scopes = scopeClaim.Value.Split(' ');

            // Check whether the required scope exists
            if (scopes.Any(s => s == requirement.Scope))
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
