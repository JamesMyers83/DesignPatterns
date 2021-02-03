using System.Collections.Generic;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    //concrete handler
    public class ActiveDirectoryLoginHandler : LoginHandler
    {
        private Dictionary<string, string> logins;

        //constructor to populate local login dictionary
        public ActiveDirectoryLoginHandler()
        {
            logins = new Dictionary<string, string>();
            logins.Add("jsmith", "LiMuEmu");
            logins.Add("dhenry", "Tom&Jerry");
            logins.Add("wuser", "password");
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
                return $"Successful login for {userName} in Active Directory!";
            else
                return base.Login(userName, password);
        }
    }
}
