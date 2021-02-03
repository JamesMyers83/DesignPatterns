namespace DesignPatterns.Behavioral.Interpreter
{
    //terminal expression
    public class BinaryExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.ExpressionString = GetBinary(context.CurrentContext);
        }

        private string GetBinary(int i)
        {
            int result = i;
            int remainder;
            string binaryString = ""; 

            while (result > 0)
            {
                remainder = result % 2;
                binaryString = remainder.ToString() + binaryString;
                result /= 2;
            }

            //remove leading zeroes
            return int.Parse(binaryString).ToString();
        }
    }
}
