namespace SDP_ASG
{
    internal class TechnicalReportFactory : DocumentFactory
    {
        public override Document createDocument()
        {
            return new TechnicalReport();
        }
    }
}
