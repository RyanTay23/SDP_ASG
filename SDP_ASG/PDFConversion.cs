namespace SDP_ASG
{
    internal class PDFConversion : Conversion
    {
        public void convertToFormat(Document document)
        {
            document.Format = "PDF";
            Console.WriteLine($"Converting {document.Name} to PDF...");
        }
    }
}
