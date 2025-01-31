using SDP_ASG;
public class Program
{
    public static void Main()
    {
        DocumentFactory technicalFactory = new TechnicalReportFactory();
        Document doc = new TechnicalReport();
        technicalFactory.createDocument();
        DocumentFactory grantFactory = new GrantProposalFactory();
        grantFactory.createDocument();
    }
}
