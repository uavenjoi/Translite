using System;

namespace Translite
{
    class Program
    {
        static void Main()
        {
            Method method = new Method();
            Console.WriteLine(method.TransliteString("Привет! Как дела?"));

            Console.ReadLine();
        }
    }
}