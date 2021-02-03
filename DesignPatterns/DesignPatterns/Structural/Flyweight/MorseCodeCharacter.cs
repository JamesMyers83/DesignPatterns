namespace DesignPatterns.Structural.Flyweight
{
    //concrete flyweight
    //this example does not make use of the unshared concrete flyweight
    public class MorseCodeCharacter : ICodedCharacter
    {
        //extrinsic properties
        private string _dot;
        private string _dash;

        //intrinsic properties
        public char Character { get; private set; }
        public string Pattern { get; private set; }

        public void SetCharacter(char character) => Character = char.ToUpper(character);
        public void SetDotString(string dot) => _dot = dot;

        public void SetDashString(string dash) => _dash = dash;

        public void SetPattern(CodeDictionary codeDictionary) => Pattern = codeDictionary.GetCodedCharacterString(Character);

        //add space after character string for character seperator
        public string GetCodedCharacter()
        {
            string codedCharacter = "";

            foreach (string p in GetPatternArray())
                codedCharacter += p;

            return codedCharacter + " ";
        }

        private string[] GetPatternArray()
        {
            string[] patternArray = new string[Pattern.Length];

            for (int c = 0; c < Pattern.Length; c++)
            {
                switch (Pattern.Substring(c, 1))
                {
                    case ".":
                        patternArray[c] = _dot;
                        break;
                    case "-":
                        patternArray[c] = _dash;
                        break;
                    case " ":
                        patternArray[c] = " ";
                        break;
                    default:
                        break;
                }
            }

            return patternArray;
        }
    }
}
