namespace DesignPatterns.Structural.Bridge
{
    //concrete implmentor
    public class Database : IDataRepo
    {
        private string dbConnection;

        public Database(string connectionString) => dbConnection = connectionString;

        public string DeleteData(string data) => $"'{data}' was deleted from DB: {dbConnection}";

        public string SaveData(string data) => $"'{data}' was saved to DB: {dbConnection}";

        public string UpdateData(string newData, string oldData) => $"'{oldData}' was replaced with '{newData}' in DB: {dbConnection}";
    }
}
