using System;

namespace Enum
{
    class Program
    {
        enum Days { Monday, Tuesday, Wenesday, Thursday, Friday, Saturday, Sunday };

        static void Main(string[] args)
        {   
            Console.WriteLine((int)Days.Monday + 1);
        }
    }
}
