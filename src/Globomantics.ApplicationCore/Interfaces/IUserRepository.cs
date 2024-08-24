using Globomantics.Data;

namespace Globomantics.ApplicationCore.Interfaces;

public interface IUserRepository
{
    UserModel? GetByUsernameAndPassword(string username, string password);

    UserModel? GetByGoogleId(string googleId);
}