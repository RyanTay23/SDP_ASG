namespace SDP_ASG
{
    internal class User : IObserver
    {
        private string name;
        private string? username, password;
        private List<Document> ownedDocuments;
        private List<Document> sharedDocuments;
        private IDocumentFactory factory;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public User(string username, string password)
        {
            //this.name = name;
            this.username = username;
            this.password = password;
            this.ownedDocuments = [];
            this.sharedDocuments = [];
        }
        //public void CreateDocument(string type)
        //{
        //    if (type == "Technical Report")
        //    {
        //        factory = new TechnicalReportFactory();
        //    }
        //    else if (type == "Grant Proposal")
        //    {
        //        factory = new GrantProposalFactory();
        //    }
        //}
        public void AddCollaborator(Document doc, User user)
        {
            if (doc.Owner == this)
            {
                doc.RegisterObserver(user);
                user.sharedDocuments.Add(doc);
            }
            else
            {
                Console.WriteLine("You do not have permissions.");
            }
        }
        public void Edit(Document doc)
        {
            if (doc.ValidEdit == true)
            {
                Console.Write("Enter content you want to add: ");
                string edit = Console.ReadLine();
                doc.Content += edit;
            }
            else
            {
                Console.WriteLine("Restricted edit permissions");
            }
        }
        public void ShowDocuments(bool owned = false) 
        {
            Console.WriteLine("My Documents");
            for(int i = 0; i < this.ownedDocuments.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ownedDocuments[i].Title}");
            }
            if (owned == false)
            {
                for (int i = 0; i < this.sharedDocuments.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {sharedDocuments[i].Title}");
                }
            }
        }
        public void Update(string message)
        {
            Console.WriteLine($"{name}, {message}");
        }
    }
}
