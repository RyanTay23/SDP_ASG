namespace SDP_ASG
{
    internal class WordConversion : Conversion
    {
        public void convertToFormat(Document document)
        {
            document.Format = "Word";
            Console.WriteLine($"Converting {document.Name} to Word...");
        }
    }
}
