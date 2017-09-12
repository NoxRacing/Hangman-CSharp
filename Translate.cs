using System;

namespace Hangman_CSharp
{
        class Translate
    {
        public static void setLocale() {
            Console.WriteLine("Enter your language (fr/en): ");
            string locale = Console.ReadLine();
            if(locale == "fr") {
                GlobalVariables.language = "french";
            } else if(locale == "en") {
                GlobalVariables.language = "english";
            } else {
                Translate.setLocale();
            }
        }
    }
}
