using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Lecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            var clients = LoadClients();
            SaveClients(clients);
        }

        #region Basics

        public static void ReadFromDocumentByLine()
        {
            //var path = "path\\to\\document";
            var path = "D:\\test.txt";

            var sr = new StreamReader(path);

            var line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);

                line = sr.ReadLine();
            }

            sr.Close();
        }

        public static void ReadEverything()
        {
            //var path = "path\\to\\document";
            var path = @"D:\test.txt";

            using (var sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
        }

        public static void ReadFromDocumentByChar()
        {
            //var path = @"path\to\document";
            var path = @"D:\test.txt";

            using (var sr = new StreamReader(path))
            {
                while (sr.EndOfStream == false)
                {
                    var character = sr.Read();

                    Console.WriteLine((char)character);
                }
            }
        }

        public static void WriteToDocumentByLine()
        {
            //var path = @"path\to\document";
            var path = @"D:\test.txt";

            // File is created if does not exist.
            // In this configuration all previous content of file will be deleted.
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine("Hello world");
            }
        }

        public static void WriteToDocumentAppend()
        {
            //var path = @"path\to\document";
            var path = @"D:\test.txt";

            // In this configuration StreamWriter will append to the end of the file.
            using (var sw = new StreamWriter(path, append: true))
            {
                sw.WriteLine("Hello world");
            }
        }

        #endregion

        #region Csv

        public static List<Address> GetAddressesFromCsv()
        {
            var addresses = new List<Address>();

            var basePath = AppContext.BaseDirectory;
            var dataFileName = "addresses.csv";
            var path = Path.Combine(basePath, dataFileName);

            using (var sr = new StreamReader(path))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    var address = ParseLineToAddress(line);
                    addresses.Add(address);

                    line = sr.ReadLine();
                }
            }

            return addresses;
        }

        public static Address ParseLineToAddress(string line)
        {
            line = line.Replace("\"", string.Empty);
            var addressComponents = line.Split(",");
            var address = new Address(addressComponents[2], addressComponents[3]);

            address.CityCode = addressComponents[4];
            address.Zip = addressComponents[5];

            return address;
        }

        #endregion

        #region Json

        public static void GetClientsFromJson()
        {
            var json = "{" +
                       "\"latitude\": 49.595875," +
                       "\"longitude\": 17.249870" +
                       "}";

            var coordinates = JsonConvert.DeserializeObject<Coordinates>(json);

            var json1 = JsonConvert.SerializeObject(coordinates);

            Console.WriteLine(json1);

        }

        #endregion

        #region ExerciseSolution

        public static List<Client> LoadClients()
        {
            var basePath = AppContext.BaseDirectory;
            var clientsFileName = "clients.json";
            var path = Path.Combine(basePath, clientsFileName);

            var clients = new List<Client>();
            using (var sr = new StreamReader(path))
            {
                var content = sr.ReadToEnd();
                clients = JsonConvert.DeserializeObject<List<Client>>(content);
            }

            var addresses = GetAddressesFromCsv();
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Address = addresses[i];
            }

            return clients;
        }

        public static void SaveClients(List<Client> clients)
        {
            var basePath = AppContext.BaseDirectory;
            var clientsFileName = "clients_with_addresses.json";
            var path = Path.Combine(basePath, clientsFileName);
            var json = JsonConvert.SerializeObject(clients);

            using (var sw = new StreamWriter(path))
            {
                sw.Write(json);
            }
        }

        #endregion
    }
}
