using System.Collections.Generic;
using System.Security.Claims;

namespace RestWithASP_NET5.Services
{
    public interface ITokenInterface
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
