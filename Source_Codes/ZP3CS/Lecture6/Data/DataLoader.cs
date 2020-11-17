using System;
using System.Collections.Generic;
using System.IO;
using Lecture6.Models;
using Newtonsoft.Json;

namespace Lecture6.Data
{
    public static class DataLoader
    {
        public static List<T> LoadDataFromJson<T>(string fileName) where T : Person
        {
            var basePath = AppContext.BaseDirectory;
            var clientsFileName = $@"Data\{fileName}";
            var path = Path.Combine(basePath, clientsFileName);

            var people = new List<T>();
            using (var sr = new StreamReader(path))
            {
                var content = sr.ReadToEnd();
                people = JsonConvert.DeserializeObject<List<T>>(content);
            }

            return people;
        }
    }
}
