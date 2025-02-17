namespace SDP_ASG
{
    internal class AccountManager
    {
        private static readonly AccountManager _instance = new AccountManager();
        private AccountManager() { }
        public static AccountManager Instance => _instance;
        private Dictionary<string, string> accounts = [];
        public Dictionary<string, string> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }
        public void Register(string username, string password)
        {
            if (!accounts.ContainsKey(username))
            {
                accounts[username] = password;
                Console.WriteLine($"User {username} registered successfully.");
            }
            else
            {
                Console.WriteLine($"Username {username} already exists.");
            }
        }
        public void Login(string username, string password)
        {
            if ((accounts.ContainsKey(username) && accounts[username] == password) == false)
            {
                Console.WriteLine("Invalid login credentials");
                return;
            }
            Console.WriteLine($"User {username} logged in successfully.");

        }
        public void ListAccounts()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Username: {account.Key}, Password: {account.Value}");
            }
        }
    }
}
