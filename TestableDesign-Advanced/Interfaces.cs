using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableDesign_Advanced
{
    public interface IUserService
    {
        bool RegisterUser(string email, string password);
    }

    public interface IHttpResponse
    {
        void WriteLine(string text);
    }

    public interface IMailingService
    {
        void SendMail(string email, string message);
    }
}
