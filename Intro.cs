using System;

namespace Hangman_CSharp
{
        class Intro
    {
        public string getHeader()
        {
            TextParsing textParsing = new TextParsing();
            string appName = "Hangman";
            string missingHashtag = "";
            for(int i = 0; i < appName.Length; i++) {
                missingHashtag += "#";
            }
            
            string title =  "    #########"+missingHashtag+"#########\n"+
                            "    ##       " + appName + "       ##\n" +
                            "    #########"+missingHashtag+"#########\n" +
                            "Author: Jimmy Béland-Bédard ----- Language: C#\n";
            title += textParsing.horizontalLine();
            return title;
        }
    }
}
