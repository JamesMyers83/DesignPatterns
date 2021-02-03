namespace DesignPatterns.Structural.Flyweight
{
    //flyweight interface
    public interface ICodedCharacter
    {
        //intrinsic properties
        char Character { get; }
        string Pattern { get; }

        void SetPattern(CodeDictionary codeDictionary);

        string GetCodedCharacter();
    }
}
