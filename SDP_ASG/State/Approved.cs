namespace SDP_ASG
{
    internal class Approved(Document document) : DocumentState(document)
    {
        // All methods tell user that document has been approved.
        public override void Submit()
        {
            Console.WriteLine("Document is approved!");
        }
        public override void Approve()
        {
            Console.WriteLine("Document is approved!");
        }
        public override void Reject()
        {
            Console.WriteLine("Document is approved!");
        }
        public override void PushBack()
        {
            Console.WriteLine("Document is approved!");
        }
        public override void NominateApprover(User user)
        {
            Console.WriteLine("Document is approved!");
        }
    }
}