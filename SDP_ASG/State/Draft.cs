namespace SDP_ASG
{
    internal class Draft(Document document) : DocumentState(document)
    {
        // Submit checks if doc is empty and if it has an approver
        public override void Submit()
        {
            if (myDocument.Content == null)
                throw new InvalidOperationException("Empty document!!!");
            base.Submit();
        }
        
        // Below methods just contains the appropriate messages
        public override void Approve()
        {
            Console.WriteLine("Your document has not been approved yet, " +
                "please submit it for review first.");
        }
        public override void Reject()
        {
            Console.WriteLine("Your document has not been rejected yet, " +
                "please submit it for review first.");
        }
        public override void PushBack()
        {
            Console.WriteLine("Your document has not been pushed back yet, " +
                "please submit it for review first.");
        }
    }
}