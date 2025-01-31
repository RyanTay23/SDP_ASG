namespace SDP_ASG
{
    internal class RejectedState : DocumentState
    {
        private Document myDocument;

        public RejectedState(Document document)
        {
            myDocument = document;
        }
        public void submitForApproval(Document document)
        {

        }
        public void approve(Document document)
        {

        }
        public void pushBack(Document document)
        {

        }
        public void reject(Document document)
        {

        }
        public void resubmit(Document document)
        {

        }
    }
}
