namespace DesignPatterns.Structural.Flyweight
{
    //internal class to assist in translating ascii characters to morse code strings
    public class MorseCodeDictionary : CodeDictionary
    {
        public override void InitializeDictionary()
        {
            _codeDictionary.Add(char.Parse("A"), ".-");
            _codeDictionary.Add(char.Parse("B"), "-...");
            _codeDictionary.Add(char.Parse("C"), "-.-.");
            _codeDictionary.Add(char.Parse("D"), "-..");
            _codeDictionary.Add(char.Parse("E"), ".");
            _codeDictionary.Add(char.Parse("F"), "..-.");
            _codeDictionary.Add(char.Parse("G"), "--.");
            _codeDictionary.Add(char.Parse("H"), "....");
            _codeDictionary.Add(char.Parse("I"), "..");
            _codeDictionary.Add(char.Parse("J"), ".---");
            _codeDictionary.Add(char.Parse("K"), "-.-");
            _codeDictionary.Add(char.Parse("L"), ".-..");
            _codeDictionary.Add(char.Parse("M"), "--");
            _codeDictionary.Add(char.Parse("N"), "-.");
            _codeDictionary.Add(char.Parse("O"), "---");
            _codeDictionary.Add(char.Parse("P"), ".--.");
            _codeDictionary.Add(char.Parse("Q"), "--.-");
            _codeDictionary.Add(char.Parse("R"), ".-.");
            _codeDictionary.Add(char.Parse("S"), "...");
            _codeDictionary.Add(char.Parse("T"), "-");
            _codeDictionary.Add(char.Parse("U"), "..-");
            _codeDictionary.Add(char.Parse("V"), "...-");
            _codeDictionary.Add(char.Parse("W"), ".--");
            _codeDictionary.Add(char.Parse("X"), "-..-");
            _codeDictionary.Add(char.Parse("Y"), "-.--");
            _codeDictionary.Add(char.Parse("Z"), "--..");
            _codeDictionary.Add(char.Parse(" "), " ");
            _codeDictionary.Add(char.Parse("1"), ".----");
            _codeDictionary.Add(char.Parse("2"), "..---");
            _codeDictionary.Add(char.Parse("3"), "...--");
            _codeDictionary.Add(char.Parse("4"), "....-");
            _codeDictionary.Add(char.Parse("5"), ".....");
            _codeDictionary.Add(char.Parse("6"), "-....");
            _codeDictionary.Add(char.Parse("7"), "--...");
            _codeDictionary.Add(char.Parse("8"), "---..");
            _codeDictionary.Add(char.Parse("9"), "----.");
            _codeDictionary.Add(char.Parse("0"), "-----");
            _codeDictionary.Add(char.Parse("."), ".-.-.-");
            _codeDictionary.Add(char.Parse(","), "--..--");
            _codeDictionary.Add(char.Parse("?"), "..--..");
        }
    }
}
