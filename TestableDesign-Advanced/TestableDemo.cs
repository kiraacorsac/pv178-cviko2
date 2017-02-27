using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableDesign_Advanced
{
    public class UserService : IUserService
    {
        public bool RegisterUser(string email, string password)
        {
            Console.WriteLine("Wrote user data into real database.");
            return true;
        }
    }

    public class MailingService : IMailingService
    {
        public void SendMail(string email, string message)
        {
            Console.WriteLine($"Sent a real mail to {email} with text: {message}");
        }
    }

    public class HttpResponse : IHttpResponse
    {
        public void WriteLine(string text)
        {
            Console.WriteLine($"wrote \"{text}\" to real response.");
        }
    }

    public class HttpController
    {
        public IUserService UserService { get; }
        public IMailingService MailingService { get; }
        public IHttpResponse Response { get; }

        public HttpController(IUserService userService, IMailingService mailingService, IHttpResponse response)
        {
            UserService = userService;
            MailingService = mailingService;
            Response = response;
        }

        public void Register(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                Response.WriteLine("Email cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                Response.WriteLine("Password cannot be empty.");
                return;
            }

            if (UserService.RegisterUser(email, password))
            {
                Response.WriteLine("Could not register your account");
                return;
            }
            MailingService.SendMail(email, "Welcome to the forum!");
            Response.WriteLine("You have been registered!");
        }

    }
}
