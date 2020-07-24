using ClassLibrary1;

namespace ClassLibrary2
{
    public class Class2
    {
        public Class2()
        {
            Class1 = new Class1();
        }

        public Class1 Class1 { get; }

        public  string GetGuid()
        {
            return Class1.Guid.ToString();
        }
    }
}
