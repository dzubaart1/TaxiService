﻿using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using TaxiData.Entities;
using TaxiData.Models;

namespace TaxiData
{
    public class JsonStorage
    {
        private string _jsonPath;
        private string _usersPath;
        private string _idPath;
        private string _driversPath;
        private string _carsPath;
        public JsonStorage()
        {
            _jsonPath = AppDomain.CurrentDomain.BaseDirectory + $"{Path.DirectorySeparatorChar}data";

            if (!Directory.Exists(_jsonPath))
            {
                Directory.CreateDirectory(_jsonPath);
            }

            Debug.WriteLine(_jsonPath);

            _usersPath = $"{_jsonPath}{Path.DirectorySeparatorChar}users.json";
            _idPath = $"{_jsonPath}{Path.DirectorySeparatorChar}id.json";
            _driversPath = $"{_jsonPath}{Path.DirectorySeparatorChar}drivers.json";
            _carsPath = $"{_jsonPath}{Path.DirectorySeparatorChar}cars.json";

            var usersFile = new FileInfo(_usersPath);
            if (!usersFile.Exists)
            {
                using FileStream fs = usersFile.Create();
            }

            var idFile = new FileInfo(_idPath);
            if (!idFile.Exists)
            {
                using FileStream fs = idFile.Create();
            }

            var driversFile = new FileInfo(_driversPath);
            if (!driversFile.Exists)
            {
                using FileStream fs = driversFile.Create();
            }

            var carsFile = new FileInfo(_carsPath);
            if (!carsFile.Exists)
            {
                using FileStream fs = carsFile.Create();
            }
        }

        public void Save(IdGenerator generator)
        {
            string json = JsonConvert.SerializeObject(generator);
            JsonSave(json, _idPath);
        }

        public void Save(List<Driver> drivers)
        {
            string json = JsonConvert.SerializeObject(drivers);
            JsonSave(json, _driversPath);
        }

        public void Save(List<Car> cars)
        {
            string json = JsonConvert.SerializeObject(cars);
            JsonSave(json, _carsPath);
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
            using var sr = new StreamReader(_idPath, Encoding.UTF8);
            return JsonConvert.DeserializeObject<IdGenerator>(sr.ReadToEnd());
        }

        public List<Driver>? GetDrivers()
        {
            using var sr = new StreamReader(_driversPath, Encoding.UTF8);
            return JsonConvert.DeserializeObject<List<Driver>>(sr.ReadToEnd());
        }

        public List<Car>? GetCars()
        {
            using var sr = new StreamReader(_carsPath, Encoding.UTF8);
            return JsonConvert.DeserializeObject<List<Car>>(sr.ReadToEnd());
        }

        private void JsonSave(string json, string path)
        {
            using var streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(json);
            streamWriter.Close();
        }
    }
}
