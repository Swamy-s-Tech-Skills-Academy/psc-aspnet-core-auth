using Globomantics.Models;

namespace GlobomanticsCookieAuth.Web.Repositories;

public interface IProposalRepository
{
    int Add(ProposalModel model);
    ProposalModel Approve(int proposalId);
    IEnumerable<ProposalModel> GetAllForConference(int conferenceId);
}