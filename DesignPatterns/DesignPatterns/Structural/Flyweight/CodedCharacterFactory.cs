using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    //flyweight factory
    //this is a simple factory pattern
    //this only returns morse coded characters
    //if other concrete codes are implemented, this should be updated to a factory method pattern or abstract factory
    public class CodedCharacterFactory
    {
        private CodeDictionary codeDictionary = new MorseCodeDictionary();
        private Dictionary<int, ICodedCharacter> codedCharacterDictionary = new Dictionary<int, ICodedCharacter>();

        public int CharacterCreationCounter { get; private set; }

        public ICodedCharacter GetCodedCharacter(int asciiCode)
        {
            if (!codedCharacterDictionary.ContainsKey(asciiCode))
            {
                MorseCodeCharacter character = new MorseCodeCharacter();
                character.SetCharacter((char)asciiCode);
                character.SetPattern(codeDictionary);
                codedCharacterDictionary.Add(asciiCode, character);
                CharacterCreationCounter++;
            }

            return codedCharacterDictionary[asciiCode];
        }
    }
}
