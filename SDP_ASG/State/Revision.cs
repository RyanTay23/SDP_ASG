namespace SDP_ASG
{
    internal class Revision(Document document) : DocumentState(document)
    {
        // Submit checks if doc was edited
        public override void Submit()
        {
            if (edited == false)
            {
                Console.WriteLine("Please make changes.");
                return;
            }
            base.Submit();
        }
        // Below methods just contains the appropriate messages
        public override void Approve()
        {
            Console.WriteLine("Document is still being revised.");
        }
        public override void Reject()
        {
            Console.WriteLine("Document pushed back, look through comments & revise");
        }
        public override void PushBack()
        {
            Console.WriteLine("Document has already been pushed back.");
        }
        public override void NominateApprover(User user)
        {
            Console.WriteLine("Cannot change approver.");
        }
    }
}
