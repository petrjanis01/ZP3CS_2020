using System;
using System.Collections.Generic;
using System.IO;
using Lecture6.Models;
using Newtonsoft.Json;

namespace Lecture6.Data
{
    public static class DataLoader
    {
        public static List<TPerson> LoadDataFromJson<TPerson>(string fileName) where TPerson : Person
        {
            var basePath = AppContext.BaseDirectory;
            var clientsFileName = $@"Data\{fileName}";
            var path = Path.Combine(basePath, clientsFileName);

            var people = new List<TPerson>();
            using (var sr = new StreamReader(path))
            {
                var content = sr.ReadToEnd();
                people = JsonConvert.DeserializeObject<List<TPerson>>(content);
            }

            return people;
        }
    }
}
