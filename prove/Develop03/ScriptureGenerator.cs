using System;
using System.Collections.Generic;
class ScriptureGenerator
{
        List<Scripture> scriptureLibrary;

        public ScriptureGenerator()
        {
           scriptureLibrary = new List<Scripture>()
           {
            new Scripture(new Reference("John", "3", "16", "17"), "For God so loved the world, that he gave his sonly begotten Son," + 
            "that whosoever believeth in him should not perish, but have everlasting life." +
            " For God sent not his Son into the world to condemn the world; " +
            "but that the world through him might be save"),
            new Scripture(new Reference("1 Nephi", "3", "7"), "And it came to pass that I, Nephi, said unto my father" + 
            " I will go and do the things which the Lord commanded, for I know that" +
            " the Lord giveth no commandments unto the children of men, save he shall prepare a way " +
            "for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("Doctrine & Covenants", "98", "1"), "Verily I say unto you my friends, " +
            "fear not, let your hearts be comforted; yea, rejoice evermore, " +
            "and in everything give thanks;"),

           };

        }

        public Scripture GetRandomScripture()
        {
            Random random = new Random();
            int index = random.Next(scriptureLibrary.Count);
            return scriptureLibrary[index];
        }
}