using Globomantics.Models;

namespace GlobomanticsCookieAuth.Web.Repositories;

public interface IConferenceRepository
{
    int Add(ConferenceModel model);
    IEnumerable<ConferenceModel> GetAll();
    ConferenceModel GetById(int id);
}