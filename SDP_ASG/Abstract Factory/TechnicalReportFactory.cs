namespace SDP_ASG
{
    internal class TechnicalReportFactory : IDocumentFactory
    {
        public IHeader CreateHeader()
        {
            return new TechnicalReportHeader();
        }
        public IFooter CreateFooter()
        {
            return new TechnicalReportFooter();
        }
    }
}
