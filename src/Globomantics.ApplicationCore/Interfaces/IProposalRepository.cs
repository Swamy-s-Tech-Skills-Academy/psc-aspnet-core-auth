using Globomantics.Data;

namespace Globomantics.ApplicationCore.Interfaces;

public interface IProposalRepository
{
    int Add(ProposalModel model);

    ProposalModel Approve(int proposalId);

    IEnumerable<ProposalModel> GetAllForConference(int conferenceId);
}