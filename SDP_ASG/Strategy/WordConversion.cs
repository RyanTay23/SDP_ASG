namespace SDP_ASG
{
    internal class WordConversion : IConversion
    {
        public void ConvertToFormat(Document document)
        {
            document.Format = "Word";
            Console.WriteLine($"Converting {document.Title} to Word...");
        }
    }
}