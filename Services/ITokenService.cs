using CatalogoAPIminimal.Models;

namespace CatalogoAPIminimal.Services
{
    public interface ITokenService
    {
        string GerarToken(string key, string issuer, string audience, UserModel user);
    }
}
