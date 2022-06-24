using SharedComponents;
using System;
using System.Reflection;

namespace HelloUranusWriter
{
    class Program
    {
        //This is a sample comment for pull request.
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloSunString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloSunString());
            }
            else
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }
        }
    }
}
