namespace SDP_ASG
{
    internal abstract class DocumentState(Document document)
    {
        // Declare fields
        protected Document myDocument = document;
        protected bool edited = false, addCollaborators = true;
        // Methods for document
        public virtual void Submit()
        {
            myDocument.SetState(myDocument.UnderReview);
            Console.WriteLine("Document is being reviewed.");
        }
        public virtual void Approve()
        {
            myDocument.SetState(myDocument.Approved);
            Console.WriteLine("Document Approved!");
        }
        public virtual void Reject()
        {
            edited = false;
            myDocument.SetState(myDocument.Rejected);
            Console.WriteLine("Document rejected.");
        }
        public virtual void PushBack()
        {
            edited = false;
            myDocument.SetState(myDocument.Revision);
            Console.WriteLine("<Comment>"); // Insert comment maybe?
            Console.WriteLine("Document pushed back.");
        }
        public virtual void Edit()
        {
            edited = true;
            Console.WriteLine("Edited document.");
        }
        public virtual void NominateApprover(User user)
        {
            if (myDocument.Observers.Contains(user))
            {
                Console.WriteLine("Approver cannot be a collaborator or owner.");
                return;
            }
            Console.WriteLine($"{user.Name} is now the approver of this document.");
            myDocument.Approver = user;
        }
    }
}
