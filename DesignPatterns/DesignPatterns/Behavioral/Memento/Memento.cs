namespace DesignPatterns.Behavioral.Memento
{ 
    //memento class
    public class Memento
    {
        //internal state
        private string _message;

        //set state
        public Memento(string message) => _message = message;

        //get state
        public string GetMessage() => _message;
    }
}
