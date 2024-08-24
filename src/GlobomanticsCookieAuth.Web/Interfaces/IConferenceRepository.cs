using Globomantics.Data;

namespace GlobomanticsCookieAuth.Web.Interfaces;

public interface IConferenceRepository
{
    int Add(ConferenceModel model);

    IEnumerable<ConferenceModel> GetAll();
    
    ConferenceModel GetById(int id);
}