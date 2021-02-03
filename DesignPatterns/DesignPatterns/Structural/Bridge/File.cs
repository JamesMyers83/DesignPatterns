namespace DesignPatterns.Structural.Bridge
{
    //concrete implmentor
    public class File : IDataRepo
    {
        private string filePath;

        public File(string fileName) => filePath = fileName;

        public string DeleteData(string data) => $"'{data}' was deleted from file: {filePath}";

        public string SaveData(string data) => $"'{data}' was saved to file: {filePath}";

        public string UpdateData(string newData, string oldData) => $"'{oldData}' was replaced with '{newData}' in file: {filePath}";
    }
}
