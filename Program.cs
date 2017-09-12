using System;
using System.Collections.Generic;

namespace Hangman_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro intro = new Intro();
            Translate translate = new Translate();
            Translate.setLocale();
            Console.WriteLine(intro.getHeader());
        }
    }
}
