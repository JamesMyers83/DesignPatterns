namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    //abstract handler
    public abstract class LoginHandler
    {
        protected LoginHandler Successor;

        public void SetSuccessor(LoginHandler successor) => Successor = successor;

        //default to call successor function 
        public virtual string Login(string userName, string password)
        {
            if (Successor != null)
                return Successor.Login(userName, password);
            else
                return "Login not found!";
        }
    }
}
