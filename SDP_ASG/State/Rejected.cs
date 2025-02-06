namespace SDP_ASG
{
    internal class Rejected(Document document) : DocumentState(document)
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
            Console.WriteLine("Please submit for approval first.");
        }
        public override void Reject()
        {
            Console.WriteLine("Document already rejected.");
        }
        public override void PushBack()
        {
            Console.WriteLine("Document is rejected.");
        }
    }
}
