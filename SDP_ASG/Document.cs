namespace SDP_ASG
{
    internal abstract class Document : Subject
    {
        protected int documentId;
        protected string name;
        protected string header;
        protected string content;
        protected string footer;
        public string format;

        private Conversion conversion;

        // Document now has references to DocumentState objects
        private DocumentState draftState;
        private DocumentState approvedState;
        private DocumentState underReviewState;
        private DocumentState rejectedState;
        private DocumentState state;

        // List of collaborators (observors)
        private List<Observer> observers;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Format
        {
            get { return format; }
            set {  format = value; }
        }

        public void setState(DocumentState state)
        {
            this.state = state;
        }

        public Document()
        {
            format = "Not Converted";
            // Create the DocumentState objects
            draftState = new DraftState(this);
            approvedState = new ApprovedState(this);
            underReviewState = new UnderReviewState(this);
            rejectedState = new RejectedState(this);

            // Initialize empty list of observers
            observers = new List<Observer>();
        }


        public virtual void submitForApproval()
        {
            state.submitForApproval(this);
        }
        public virtual void approve()
        {
            state.approve(this);
        }
        public virtual void pushBack()
        {
            state.pushBack(this);
        }
        public virtual void reject()
        {
            state.reject(this);
        }
        public virtual void resubmit()
        {
            state.resubmit(this);
        }

        //Subject interface methods
        public void registerObserver (Observer o)
        {
            observers.Add(o);
        }
        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }
        public void notifyObservers()
        {
            foreach (Observer o in observers)
            {
                o.update();
            }
        }
        public void stateChanged()
        {
            notifyObservers();
        }

        public void SetConversionStrategy(Conversion c)
        {
            conversion = c;
        }
        public void Convert()
        {
            if (conversion == null)
            {
                Console.WriteLine("No conversion format set");
                return;
            }
            conversion.convertToFormat(this);
        }
    }
}
