namespace SDP_ASG
{
    internal class UnderReview(Document document) : DocumentState(document)
    {
        // Below methods just contains the appropriate messages
        public override void Submit()
        {
            Console.WriteLine("Your document is already under review.");
        }
        public override void Edit()
        {
            Console.WriteLine("No further edits can be made while document is in review");
        }
        public override void NominateApprover(User user)
        {
            Console.WriteLine("Your approver is already reviewing your document.");
        }
    }
}
