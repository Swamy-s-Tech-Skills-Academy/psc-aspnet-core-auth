using Globomantics.ApplicationCore.Extensions;
using Globomantics.ApplicationCore.Interfaces;
using Globomantics.Data;

namespace Globomantics.Repositories;

public class UserRepository : IUserRepository
{
    private List<UserModel> users = new()
    {
        new UserModel { Id = 3522, Name = "admin", Password = "8vaQIrtcegupA4jEziTwToaifjt+jQFTXivLKXE3/Ms=",
            FavoriteColor = "blue", Role = "Admin", GoogleId = "101517359495305583936" },
        new UserModel { Id = 3522, Name = "user", Password = "8vaQIrtcegupA4jEziTwToaifjt+jQFTXivLKXE3/Ms=",
            FavoriteColor = "yellow", Role = "User", GoogleId = "101517359495305583936" }
    };

    public UserModel? GetByUsernameAndPassword(string username, string password)
    {
        var user = users.SingleOrDefault(u => u.Name == username && u.Password == password.Sha256());

        return user;
    }

    public UserModel? GetByGoogleId(string googleId)
    {
        var user = users.SingleOrDefault(u => u.GoogleId == googleId);
        return user;
    }
}
