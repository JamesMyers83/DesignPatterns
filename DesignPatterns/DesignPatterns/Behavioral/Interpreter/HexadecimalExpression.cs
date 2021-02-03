namespace DesignPatterns.Behavioral.Interpreter
{
    //terminal expression
    public class HexadecimalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            context.ExpressionString = GetHex(context.CurrentContext);
        }

        private string GetHex(int i)
        {
            int result = i;
            int remainder;
            string hexString = i == 0 ? "0" : ""; //account for user input of 0

            while (result > 0)
            {
                remainder = result % 16;

                if (remainder > 9)
                    hexString = (char)(remainder + 55) + hexString;
                else
                    hexString = remainder.ToString() + hexString;

                result /= 16;
            }

            return hexString;
        }
    }
}
