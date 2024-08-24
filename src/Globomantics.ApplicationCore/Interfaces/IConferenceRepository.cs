using Globomantics.Data;

namespace Globomantics.ApplicationCore.Interfaces;

public interface IConferenceRepository
{
    int Add(ConferenceModel model);

    IEnumerable<ConferenceModel> GetAll();

    ConferenceModel GetById(int id);
}