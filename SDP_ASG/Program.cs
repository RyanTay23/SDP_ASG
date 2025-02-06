using SDP_ASG;
public class Program
{
    public static void Main()
    {
        // User creation
        User tom = new("Tom"), karon = new("Karon"), harry = new("Harry"), jimmy = new("Jimmy");

        // Document creation
        Document doc = new(tom)
        {
            Content = "Hello World"
        };

        // Observer Design Pattern test run
        //doc.RegisterObserver(jimmy);
        //Console.WriteLine("Observers: ");
        //Console.WriteLine($"- {doc.Owner.Name} (owner)");
        //foreach (var o in doc.Observers)
        //{
        //    if (o.Name != doc.Owner.Name)
        //    {
        //        Console.WriteLine($"- {o.Name}");
        //    }
        //}

        // State Design Pattern test run
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
    }
}