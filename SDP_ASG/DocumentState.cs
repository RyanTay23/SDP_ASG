using System.Reflection.Metadata;

namespace SDP_ASG
{
    internal interface DocumentState
    {
        void submitForApproval(Document document);
        void approve(Document document);
        void pushBack(Document document);
        void reject(Document document);
        void resubmit(Document document);
    }
}
