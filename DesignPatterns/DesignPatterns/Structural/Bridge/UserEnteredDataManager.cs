namespace DesignPatterns.Structural.Bridge
{
    //refined abstraction of data manager
    public class UserEnteredDataManager : AbstractDataManager
    {
        public UserEnteredDataManager(IDataRepo repo) : base(repo)
        {
        }

        public override string DeleteDataFromRepo(string data)
        {
            return dataRepo.DeleteData(data);
        }

        public override string SaveDataToRepo(string data)
        {
            return dataRepo.SaveData(data);
        }

        public override string UpdateDataInRepo(string oldData, string newData)
        {
            return dataRepo.UpdateData(newData, oldData);
        }
    }
}
