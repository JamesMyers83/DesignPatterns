using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace DesignPatterns.Behavioral.Mediator
{
    //concrete mediator
    public class ProductOwner : IMediator
    {
        private List<Developer> developers = new List<Developer>();
        private List<BusinessUser> businessUsers = new List<BusinessUser>();

        public void AddDeveloper(Developer developer) => developers.Add(developer);

        public void AddBusinessUser(BusinessUser businessUser) => businessUsers.Add(businessUser);

        public string PassMessage(string message, Employee employee, Project project)
        {
            string allResponses = $"{message}";

            if (employee is Developer)
            {
                foreach (BusinessUser businessUser in businessUsers)
                    allResponses += "\r\n" + businessUser.Listen(project);
            }
            else
            {
                foreach (Developer developer in developers)
                    allResponses += "\r\n" + developer.Listen(project);
            }

            return allResponses;
        }

        public string AssignDeveloper(Developer developer)
        {
            return developer.Communicate();
        }
    }
}
