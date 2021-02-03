namespace DesignPatterns.Behavioral.Memento
{
    //originator class
    public class MessageOriginator
    {
        public MessageOriginator(string contents)
        {
            MessageContents = contents;
        }

        public string MessageContents { get; private set; }

        public Memento Save() => new Memento(MessageContents);

        public void Restore(Memento memento)
        {
            MessageContents = memento.GetMessage();
        }
    }
}
