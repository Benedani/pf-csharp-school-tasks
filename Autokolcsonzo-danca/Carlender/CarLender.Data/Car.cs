using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarLender.Types
{
    public class Car
    {
        public string RegistrationNumber { get; protected set; } = "";
        public string Manufacturer { get; protected set; } = "";
        public string Brand { get; protected set; } = "";
        public int Consumption { get; protected set; } = 0;
        public bool[] IsLended { get; } = new bool[Constants.DAY_COUNT];

        Car() { }

        public void SetLendedAndSave(int dayId)
        {
            if (IsLended[dayId])
                throw new AccessViolationException($"The car is already lended for day {dayId}!");

            StreamWriter sw = new StreamWriter("Kölcsönzés.csv", true);
            sw.WriteLine($"{RegistrationNumber};{dayId + 1}");
            sw.Close();

            IsLended[dayId] = true;
        }

        /// <param name="path">Path to the CSV file.</param>
        /// <param name="skipLines">Number of lines at the start of the file to skip.
        /// (Do not skip the column titles, as they are used to identify the data!)</param>
        /// <returns>The cars successfully loaded from the CSV file.</returns>
        public static Car[] LoadCSV(string path, char separator, int skipLines = 0)
        {
            StreamReader sr = new(path);
            for (; skipLines > 0; skipLines--) sr.ReadLine();
            List<Dictionary<string, string>> csvData = CSVReader.LoadData(sr, separator);
            sr.Close();

            int i32parse;
            List<Car> cars = csvData.Select(dict => new Car()
                {
                    RegistrationNumber = dict.GetValueOrDefault("Rendszám", ""),
                    Manufacturer = dict.GetValueOrDefault("Gyártó", ""),
                    Brand = dict.GetValueOrDefault("Márka", ""),
                    Consumption = int.TryParse(dict.GetValueOrDefault("Fogyasztás", "0"), out i32parse) ? i32parse : 0,
                }).ToList();

            return cars.ToArray();
        }

        public static void LoadLendedStatusFromCSV(Car[] cars, string path, char separator, int skipLines = 0)
        {
            StreamReader sr = new(path);
            for (; skipLines > 0; skipLines--) sr.ReadLine();
            List<Dictionary<string, string>> csvData = CSVReader.LoadData(sr, separator);
            sr.Close();

            int i32parse;
            foreach (var dict in csvData)
            {
                string regNumber = dict.GetValueOrDefault("Rendszám", "");
                int day = (int.TryParse(dict.GetValueOrDefault("Konferencia napja, amikorra kikölcsönözték", "0"), out i32parse) ? i32parse : 0) - 1;
                
                // The default value for day is 0 - 1, so if the data is incorrect,
                // nothing will happen even with a valid car
                if (day >= 0 && day < Constants.DAY_COUNT)
                {
                    var query = cars.Where(car => car.RegistrationNumber == regNumber);
                    if (query.Count() > 0)
                    {
                        query.First().IsLended[day] = true;
                    }
                }
            }
        }
    }
}
