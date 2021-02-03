namespace DesignPatterns.Structural.Bridge
{
    //implementor interface
    //interface does not have to correspond exactly to the abstraction's interface
    public interface IDataRepo
    {
        string SaveData(string data);
        string DeleteData(string data);
        string UpdateData(string newData, string oldData);
    }
}
