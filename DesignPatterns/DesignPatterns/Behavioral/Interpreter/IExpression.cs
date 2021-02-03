namespace DesignPatterns.Behavioral.Interpreter
{
    //abstract expression
    public interface IExpression
    {
        public void Interpret(Context context);
    }
}
