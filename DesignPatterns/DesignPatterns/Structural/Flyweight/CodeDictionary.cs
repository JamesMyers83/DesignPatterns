using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    //abstract class to create a code dictionary. This is not a part of the pattern, but assists with implementing the idea
    public abstract class CodeDictionary
    {
        public Dictionary<char, string> _codeDictionary = new Dictionary<char, string>();

        protected CodeDictionary() => InitializeDictionary();

        public abstract void InitializeDictionary();

        public string GetCodedCharacterString(char character) => _codeDictionary[character];
    }
}
