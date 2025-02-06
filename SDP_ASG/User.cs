namespace SDP_ASG
{
    internal class User : IObserver
    {
        private string name;
        private string? username, password;
        private List<Document> documents;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public User(string name)
        {
            this.name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{name}, {message}");
        }
    }
}
