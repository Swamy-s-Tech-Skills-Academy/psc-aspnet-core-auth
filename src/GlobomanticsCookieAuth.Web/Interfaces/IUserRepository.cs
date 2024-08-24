namespace GlobomanticsCookieAuth.Web.Interfaces;

public interface IUserRepository
{
    UserModel? GetByUsernameAndPassword(string username, string password);
    UserModel? GetByGoogleId(string googleId);
}