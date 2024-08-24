using Globomantics.Data;

namespace GlobomanticsCookieAuth.Web.Interfaces;

public interface IProposalRepository
{
    int Add(ProposalModel model);

    ProposalModel Approve(int proposalId);
    
    IEnumerable<ProposalModel> GetAllForConference(int conferenceId);
}