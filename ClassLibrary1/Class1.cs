using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {
            Guid = Guid.NewGuid();
        }

        public Guid Guid { get; }
    }
}
