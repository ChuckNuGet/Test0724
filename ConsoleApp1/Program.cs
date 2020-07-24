using System;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                Class2 class2 = new Class2();
                var guid = class2.GetGuid();
                Console.WriteLine(guid);
                Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
