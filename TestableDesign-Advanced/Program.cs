using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestableDesign_Advanced
{
    public class Program
    {
        public static void Main()
        {
            var httpController = new HttpController(new UserService(), new MailingService(), new HttpResponse());

            httpController.Register("","123456");

            Console.ReadKey();
        }
    }
}
