using System;

namespace HelloWorld
{
    class Hello
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello, world!");
            Console.Out.WriteLine("Hello, world!");
            Console.Out.WriteLine("Hello, world!");
            Console.Out.WriteLine("Hello, world!");
            Console.Out.WriteLine("Hello, world!");
        }
    }
}

// mcs hellworld.cs
// mono hellworld.exe
