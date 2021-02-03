using System;

namespace DesignPatterns.Structural.Bridge
{
    //refined abstraction of data manager
    public class LogDataManager : AbstractDataManager
    {
        public LogDataManager(IDataRepo repo) : base(repo)
        {
        }

        public override string DeleteDataFromRepo(string data)
        {
            return "Cannot delete log data";
        }

        public override string SaveDataToRepo(string data)
        {
            string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmssffff");
            return dataRepo.SaveData($"Log_{timeStamp}: {data}");
        }

        public override string UpdateDataInRepo(string oldData, string newData)
        {
            return "Cannot update log data";
        }
    }
}
