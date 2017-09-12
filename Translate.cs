using System;

namespace Hangman_CSharp
{
        class Translate
    {
        public static void setLocale() {
            Console.Write("Enter your language | Entrez votre langue (fr/en): ");
            string locale = Console.ReadLine();
            Console.Write("\n");
            if(locale == "fr") {
                GlobalVariables.language = "french";
            } else if(locale == "en") {
                GlobalVariables.language = "english";
            } else {
                Console.WriteLine("Language unrecognized | Language non-reconnu");
                Translate.setLocale();
            }
        }
    }
}
