using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using nmnielsen.Repository.Interfaces;
using System.IdentityModel.Tokens.Jwt;

namespace nmnielsen.Repository.Repositories;
public class UserRepository : IUserRepository
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    public UserRepository(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    } 

    public async Task<bool> CheckUserPermission(string neededRole)
    {
        List<string> permissions = new();
        JwtSecurityTokenHandler handler = new();

        string jwt = await _httpContextAccessor.HttpContext.GetTokenAsync("access_token");

        if (jwt is null)
        {
            return false;
        }

        JwtSecurityToken token = handler.ReadJwtToken(jwt);
        foreach (var claim in token.Claims)
        {
            if (claim.Type == "permissions")
            {
                permissions.Add(claim.Value);
            }
        }

        if (permissions.Contains(neededRole))
        {
            return true;
        }

        return false;
    }
}
