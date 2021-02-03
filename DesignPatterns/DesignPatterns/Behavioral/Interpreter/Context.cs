namespace DesignPatterns.Behavioral.Interpreter
{
    //context
    public class Context
    {
        public Context(int base10)
        {
            CurrentContext = base10;
        }

        public int CurrentContext { get; }
        public string ExpressionString { get; set; }
    }
}
