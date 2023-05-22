using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using TaxiData.Entities;
using TaxiData.Tools;

namespace TaxiData
{
    public class JsonStorage
    {
        private string _jsonPath;
        private string _usersPath;
        private string _idFilePath;
        public JsonStorage()
        {
            _jsonPath = AppDomain.CurrentDomain.BaseDirectory + $"{Path.DirectorySeparatorChar}data";

            if (!Directory.Exists(_jsonPath))
            {
                Directory.CreateDirectory(_jsonPath);
            }

            _usersPath = $"{_jsonPath}{Path.DirectorySeparatorChar}users.json";
            _idFilePath = $"{_jsonPath}{Path.DirectorySeparatorChar}id.json";

            var usersFile = new FileInfo(_usersPath);
            if (!usersFile.Exists)
            {
                usersFile.Create();
            }

            var idFile = new FileInfo(_idFilePath);
            if (!idFile.Exists)
            {
                idFile.Create();
            }
        }

        public void Save(IdGenerator? generator)
        {
            string json = JsonConvert.SerializeObject(generator);
            JsonSave(json, _idFilePath);
        }

        public void Save(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users);
            JsonSave(json, _usersPath);
        }

        public List<User>? GetUsers()
        {
            using var sr = new StreamReader(_usersPath, Encoding.UTF8);
            return JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());
        }

        public IdGenerator? GetIdGenerator()
        {
            using var sr = new StreamReader(_idFilePath, Encoding.UTF8);
            return JsonConvert.DeserializeObject<IdGenerator>(sr.ReadToEnd());
        }

        private void JsonSave(string json, string path)
        {
            using var streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(json);
            streamWriter.Close();
        }

    }
}
