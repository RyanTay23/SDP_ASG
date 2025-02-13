namespace SDP_ASG
{
    internal class GrantProposalFactory : IDocumentFactory
    {
        public IHeader CreateHeader()
        {
            return new GrantProposalHeader();
        }
        public IFooter CreateFooter()
        {
            return new GrantProposalFooter();
        }
    }
}
