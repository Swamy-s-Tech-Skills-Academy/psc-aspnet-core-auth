using Globomantics.Models;

namespace GlobomanticsCookieAuth.Web.Repositories;

public interface IUserRepository
{
    UserModel? GetByUsernameAndPassword(string username, string password);
    UserModel? GetByGoogleId(string googleId);
}