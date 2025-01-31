namespace SDP_ASG
{
    internal class GrantProposalFactory : DocumentFactory
    {
        public override Document createDocument()
        {
            return new GrantProposal();
        }
    }
}
