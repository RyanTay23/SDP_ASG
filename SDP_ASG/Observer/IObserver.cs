namespace SDP_ASG 
{ 
    internal interface IObserver
    {
        //string Name { get; set; }       // Username
        void Update(string message);    // Notify user of changes to document
    }
}
