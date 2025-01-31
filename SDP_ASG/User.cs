namespace SDP_ASG
{
    internal class User : Observer
    {
        private Subject document;

        public User(Subject doc)
        {
            this.document = doc;
            document.registerObserver(this);
        }
        public void update()
        {
            // Update necessary values
        }
    }
}
