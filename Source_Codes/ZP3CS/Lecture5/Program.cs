﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Lecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            GetClientsFromJson();
        }

        #region Basics

        public static void ReadFromDocumentByLine()
        {
            //var path = "path\\to\\document";
            var path = @"D:\test.txt";

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
                var character = sr.Read();

                while (sr.EndOfStream == false)
                {
                    Console.WriteLine((char)character);

                    character = sr.Read();
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
            var addressComponents = line.Split(",");
            var address = new Address();

            address.FirstName = addressComponents[0];
            address.Surname = addressComponents[1];
            address.Street = addressComponents[2];
            address.City = addressComponents[3];
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

            // TODO serialize/deserialize

            // TODO add coordinates to address
        }

        #endregion
    }
}
