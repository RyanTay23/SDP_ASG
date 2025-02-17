namespace SDP_ASG
{
    internal abstract class Document : ISubject
    {
        // Declare fields
        private DocumentState draft, underReview, rejected, approved, revision, state;
        private string? title, message, format, type;
        protected string content;
        protected IHeader header;
        protected IFooter footer;
        private List<IObserver> observers;
        private User owner;
        private User? approver;
        private bool validEdit = true;
        private IConversion conversion;


        // Getters & Setters for Document states 
        public DocumentState Draft
        {
            get => draft;
            set => draft = value;
        }
        public DocumentState UnderReview
        {
            get => underReview;
            set => underReview = value;
        }
        public DocumentState Rejected
        {
            get => rejected;
            set => rejected = value;
        }
        public DocumentState Approved
        {
            get => approved;
            set => approved = value;
        }
        public DocumentState Revision
        {
            get => revision;
            set => revision = value;
        }
        // Getters & Setters for others
        public string? Title
        {
            get => title;
            set => title = value;
        }
        public string? Content
        {
            get => content;
            set => content = value;
        }
        public List<IObserver> Observers
        {
            get => observers;
            set => observers = value;
        }
        public User Owner
        {
            get => owner;
            set => owner = value;
        }
        public User Approver
        {
            get => approver;
            set => approver = value;
        }
        public string? Format
        {
            get => format;
            set => format = value;
        }
        public string? Type
        {
            get => type;
            set => type = value;
        }
        public bool ValidEdit
        {
            get => validEdit;
            set => validEdit = value;
        }
        public IConversion Conversion
        {
            get => conversion;
            set => conversion = value;
        }
        // SetState updates current state and notify observers
        public void SetState(DocumentState state)
        {
            this.state = state;
            NotifyObservers();
        }

        // Constructor
        public Document()
        {
            draft = new Draft(this);
            underReview = new UnderReview(this);
            rejected = new Rejected(this);
            approved = new Approved(this);
            revision = new Revision(this);
            this.state = draft;
            this.observers = [];
            //this.owner = user;
            //this.title = title;
            //this.RegisterObserver(user);
        }

        // State Design Pattern methods
        public void Submit()
        {
            message = "the document has been submitted for approval.";
            state.Submit();
        }
        public void Approve()
        {
            state.Approve();
            message = "the document is approved.";
        }
        public void Reject()
        {
            state.Reject();
            message = "the document is rejected.";
        }
        public void PushBack()
        {
            state.PushBack();
            message = "the document was pushed back.";
        }
        public void Edit()
        {
            state.Edit();
        }
        public void NominateApprover(User user)
        {
            state.NominateApprover(user);
        }
        // Observer methods
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
        public void AddContent(string content)
        {
            this.content += content + "\n";
        }
        public abstract void CreateDocument();
        public abstract void Display();
    }
}
