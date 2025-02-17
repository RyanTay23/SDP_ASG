namespace SDP_ASG
{
    internal class PDFConversion : IConversion
    {
        public void ConvertToFormat(Document document)
        {
            document.Format = "PDF";
            Console.WriteLine($"Converting {document.Title} to PDF...");
        }
    }
}