using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using CarLender.Types;

namespace CarLender.BL
{
    public static class GUI_Interface
    {
        public enum ShopDataSource
        {
            AutokCSV
        }
        public enum OrderResult
        {
            OK, Error
        }

        static Car[] GetCars(ShopDataSource source)
        {
            switch (source)
            {
                case ShopDataSource.AutokCSV:
                    {
                        Car[] cars = Car.LoadCSV("Autok.csv", ';', 1);
                        Car.LoadLendedStatusFromCSV(cars, "Kölcsönzés.csv", ';', 1);
                        return cars;
                    }
            }
            return null;
        }

        static string ValueToString(object o)
        {
            if (o is bool[] barr)
            {
                return string.Join("", barr.Select(b => b ? "1" : "0"));
            }
            return o.ToString();
        }

        public static Dictionary<string, string[]> GetShopData(ShopDataSource source, string[] fields)
        {
            Car[] cars = GetCars(source);

            PropertyInfo[] propInfos = fields.Select(field => typeof(Car).GetProperty(field, BindingFlags.Public | BindingFlags.Instance)).ToArray();

            return cars.ToDictionary(car => car.RegistrationNumber, car => propInfos.Select(p => ValueToString(p.GetValue(car))).ToArray());
        }

        public static OrderResult Order(ShopDataSource source, string name, string idNumber, string carRN, int day, out string information)
        {
            try
            {
                Car[] cars = GetCars(source);
                Dictionary<string, Car> carsDict = cars.ToDictionary(t => t.RegistrationNumber, t => t);

                Car ourCar = carsDict[carRN];

                if (ourCar.IsLended[day])
                {
                    information = $"We are terribly sorry, somebody has just booked that car for day {day + 1} of the conference.";
                    return OrderResult.Error;
                }

                ourCar.SetLendedAndSave(day);

                information = $"Dear {name}! You have successfully booked the car with the registration number {carRN} for day {day + 1} of the conference.";

                return OrderResult.OK;
            }
            catch (Exception e)
            {
                information = e.ToString();
                return OrderResult.Error;
            }
        }
    }
}
