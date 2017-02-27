using System;

namespace BasicClassMembers_03
{
    /// <summary>
    /// Based on demo sample of David Kadlec
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // see ClassExample for more details...
            var classExampleInstance = new ClassExample();
            var classExampleInstance2 = new ClassExample(new Random(42));
        }
    }
}
