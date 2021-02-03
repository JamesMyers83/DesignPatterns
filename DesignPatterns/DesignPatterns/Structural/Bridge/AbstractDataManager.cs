namespace DesignPatterns.Structural.Bridge
{
    //abstraction
    //abstractions typically define higher level operations based on the interface primitive operations
    public abstract class AbstractDataManager
    {
        protected IDataRepo dataRepo;

        protected AbstractDataManager(IDataRepo repo) => dataRepo = repo;

        public abstract string SaveDataToRepo(string data);
        public abstract string DeleteDataFromRepo(string data);
        public abstract string UpdateDataInRepo(string oldData, string newData);
    }
}
