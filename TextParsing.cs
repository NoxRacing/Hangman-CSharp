using System;

namespace Hangman_CSharp
{
        class TextParsing
    {
        public string horizontalLine()
        {
            string horizontalLine = "";
            for (int i = 0; i < 80; i++) {
                horizontalLine += "-";
            }
            horizontalLine += '\n';
            return horizontalLine;
        }
    }
}
