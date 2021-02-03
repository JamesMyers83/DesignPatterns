namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    //implement chain of responsibility
    public class LoginRequester
    {
        private ActiveDirectoryLoginHandler ad = new ActiveDirectoryLoginHandler();
        private GoogleLoginHandler google = new GoogleLoginHandler();
        private FacebookLoginHandler facebook = new FacebookLoginHandler();

        public LoginRequester()
        {
            ad.SetSuccessor(google);
            google.SetSuccessor(facebook);
        }

        public string GetLoginResponse(string userName, string password) => ad.Login(userName, password);
    }
}
