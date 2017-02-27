using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableDesign_Advanced;

namespace TestableDesign.Test_Advanced
{
    public class FakeResponse : IHttpResponse
    {
        public StringBuilder OutputText { get; } = new StringBuilder();
        public void WriteLine(string text)
        {
            OutputText.Append(text);
        }
    }

    public class FakeMailingService : IMailingService
    {
        private string LastMessage { get; set; } = "";
        public void SendMail(string email, string message)
        {
            LastMessage = message;
        }
    }

    public class FakeUserService : IUserService
    {
        public bool Result { get; }

        public FakeUserService(bool result)
        {
            Result = result;
        }

        public bool RegisterUser(string email, string password)
        {
            return Result;
        }
    }

    [TestClass]
    public class HttpControllerTests
    {
        [TestMethod]
        public void HttpController_NameNotFilled_Error()
        {
            var controller = new HttpController(new FakeUserService(true), new FakeMailingService(), new FakeResponse());

            controller.Register("","12346");

            var fakeResponse = (FakeResponse) controller.Response;

            Assert.AreEqual("Email cannot be empty.", fakeResponse.OutputText.ToString());
        }
    }
}
