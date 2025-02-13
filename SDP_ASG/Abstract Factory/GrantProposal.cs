namespace SDP_ASG
{
    internal class GrantProposal : Document
    {
        private IDocumentFactory documentFactory;
        public GrantProposal(IDocumentFactory df)
        {
            this.documentFactory = df;
        }
        public override void CreateDocument()
        {
            header = documentFactory.CreateHeader();
            footer = documentFactory.CreateFooter();
        }
        public override void Display()
        {
            Console.WriteLine(header.GetHeader());
            Console.WriteLine(this.content);
            Console.WriteLine(footer.GetFooter());
        }
    }
}
