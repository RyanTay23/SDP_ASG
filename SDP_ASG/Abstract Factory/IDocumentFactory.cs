namespace SDP_ASG
{
    internal interface IDocumentFactory
    {
        // Creating products
        IHeader CreateHeader();
        IFooter CreateFooter();
    }
}
