using EventAuthApi.Models;

namespace EventAuthApi.Services;

public interface IJwtTokenService
{
    string CreateToken(ApplicationUser user, IList<string> roles);
}
