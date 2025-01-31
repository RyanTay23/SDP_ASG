namespace SDP_ASG
{
    internal class GrantProposal : Document
    {
        public string fundingDetails { get; set; }
        public override void submitForApproval()
        {
            base.submitForApproval();
        }
        public override void approve()
        {
            base.approve();
        }
        public override void reject()
        {
            base.reject();
        }
        public override void pushBack()
        {
            base.pushBack();
        }
    }
}
