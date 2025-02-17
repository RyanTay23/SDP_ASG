using SDP_ASG;
public class Program
{
    public static void Main()
    {
        //// User creation
        //User tom = new("Tom"), karon = new("Karon"), harry = new("Harry"), jimmy = new("Jimmy");

        //// Document creation
        //TechnicalReportFactory tf = new();
        //Document doc = new TechnicalReport(tf);
        //doc.CreateDocument();
        //doc.AddContent("Hello World");
        ////Observer Design Pattern test run
        //doc.RegisterObserver(jimmy);
        ////Console.WriteLine("Observers: ");
        ////Console.WriteLine($"- {doc.Owner.Name} (owner)");
        ////foreach (var o in doc.Observers)
        ////{
        ////    if (o.Name != doc.Owner.Name)
        ////    {
        ////        Console.WriteLine($"- {o.Name}");
        ////    }
        ////}

        //doc.Display();
        ////State Design Pattern test run
        //doc.NominateApprover(tom);      // Nominating a collaborator/owner as approver
        //doc.NominateApprover(karon);    // Valid nomination test
        //doc.Submit();                   // Submitting empty document
        //doc.Edit();                     // Adding content to document             
        //doc.Reject();
        //doc.Submit();                   // Submitting without making changes after rejection
        //doc.Edit();                     // Making changes to rejected document
        //doc.Submit();                   // Resubmitting document after rejection
        //doc.PushBack();
        //doc.Submit();                   // Submitting without making changes after pushed back
        //doc.Edit();                     // Making changes to pushed back document
        //doc.NominateApprover(harry);    // Nominating a different approver after pushed back
        //doc.Submit();                   // Resubmitting document after pushed back
        //doc.Approve();
        //doc.Format = "PDF";
        ////doc.Conversion.ConvertToFormat(doc);

        Console.Write("1. Sign up\n2. Login\nEnter(0 to quit): ");
        string input = Console.ReadLine();
        Dictionary<string, string> credentials = new();
        foreach(var line in File.ReadLines("C:\\Users\\Ryan Tay\\Desktop\\SDP\\ASG\\SDP_ASG\\SDP_ASG\\Credentials.txt"))
        {
            var parts = line.Split(',');
            if (parts.Length == 2)
            {
                string key = parts[0];
                string value = parts[1];
                credentials[key] = value;
            }
        }
        while (input != "0")
        {
            if(input == "1")
            {
                while (true)
                {
                    Console.Write("Enter username(0 to quit): ");
                    string username = Console.ReadLine();
                    if (!credentials.ContainsKey(username))
                    {
                        Console.Write("Enter password: ");
                        string password = Console.ReadLine();
                        Console.WriteLine("You've signed up");
                        using (StreamWriter writer = new StreamWriter("C:\\Users\\Ryan Tay\\Desktop\\SDP\\ASG\\SDP_ASG\\SDP_ASG\\Credentials.txt", true))
                        {
                            writer.WriteLine($"{username},{password}");
                        }
                        break;
                    }
                    Console.WriteLine("Username already exists.");
                }
            }
            else
            {
                bool logged = false;
                while (logged == false)
                {
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    if (credentials.ContainsKey(username))
                    {
                        while (true)
                        {
                            Console.Write("Enter password: ");
                            string password = Console.ReadLine();
                            if (credentials[username] == password)
                            {
                                Console.WriteLine("You've logged in.");
                                logged = true;
                                break;
                            }
                            Console.WriteLine("Incorrect password");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Username doesn't exists.");
                    }
                    break;
                }
            }
        }
    }
}