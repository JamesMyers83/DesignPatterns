using System.Collections.Generic;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    //concrete handler
    public class GoogleLoginHandler : LoginHandler
    {
        private Dictionary<string, string> logins;

        //constructor to populate local login dictionary
        public GoogleLoginHandler()
        {
            logins = new Dictionary<string, string>();
            logins.Add("bugsBunny", "what'sUpDoc?");
            logins.Add("donalDuck", "dispicable");
            logins.Add("elmerFudd", "rascallyRabbit");
            logins.Add("admin", "admin");
        }

        //logic to check if login local or to pass ot next handler
        public override string Login(string userName, string password)
        {
            bool isLoginSuccess = false;

            if (logins.ContainsKey(userName))
                if (logins[userName] == password)
                    isLoginSuccess = true;

            if (isLoginSuccess)
                return $"Successful login for {userName} in Google!";
            else
                return base.Login(userName, password);
        }
    }
}
