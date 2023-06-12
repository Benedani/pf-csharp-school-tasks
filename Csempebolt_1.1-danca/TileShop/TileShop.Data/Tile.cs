using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TileShop.Types
{
    public class Tile
    {
        public int ID { get; protected set; } = 0;
        public string Manufacturer { get; protected set; } = "";
        public string Name { get; protected set; } = "";
        public string Size { get; protected set; } = "";
        public int Price { get; protected set; } = 0;
        public int Quantity { get; protected set; } = 0;

        Tile() { }

        /// <param name="path">Path to the CSV file.</param>
        /// <param name="skipLines">Number of lines at the start of the file to skip.
        /// (Do not skip the column titles, as they are used to identify the data!)</param>
        /// <returns>The tiles successfully loaded from the CSV file.</returns>
        public static Tile[] LoadCSV(string path, char separator, int skipLines = 0)
        {
            StreamReader sr = new(path);

            for (; skipLines > 0; skipLines--) sr.ReadLine();
            List<Dictionary<string, string>> csvData = LoadCSVData(sr, separator);

            sr.Close();

            List<Tile> tiles = new();
            int i32parse;
            foreach (var dict in csvData)
            {
                tiles.Add(new()
                {
                    ID = int.TryParse(dict.GetValueOrDefault("ID", "0"), out i32parse) ? i32parse : 0,
                    Manufacturer = dict.GetValueOrDefault("Gyártó", ""),
                    Name = dict.GetValueOrDefault("Név", ""),
                    Size = dict.GetValueOrDefault("Méret (szé. x mag.)", ""),
                    Price = int.TryParse(dict.GetValueOrDefault("Ár (Ft)", "0"), out i32parse) ? i32parse : 0,
                    Quantity = int.TryParse(dict.GetValueOrDefault("Raktáron", "0"), out i32parse) ? i32parse : 0,
                });
            }

            return tiles.ToArray();
        }

        static List<Dictionary<string, string>> LoadCSVData(StreamReader sr, char separator)
        {
            List<Dictionary<string, string>> result = new();

            string[] titles = ReadCSVRow(sr, separator);

            while (!sr.EndOfStream)
            {
                string[] data = ReadCSVRow(sr, separator);

                Dictionary<string, string> dict = new();

                for (int i = 0; i < titles.Length && i < data.Length; i++)
                {
                    dict.Add(titles[i], data[i]);
                }

                result.Add(dict);
            }

            return result;
        }

        static string[] ReadCSVRow(StreamReader sr, char separator)
        {
            List<string> row = new();

            string current = "";
            int starti = 0;
            bool inString = false;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '"')
                    {
                        // check for "" (quote in string)
                        if (i + 1 < line.Length && line[i + 1] == '"')
                        {
                            i++; // skip next "
                        }
                        else
                        {
                            inString = !inString;
                            continue;
                        }
                    }
                    else if (!inString && line[i] == separator)
                    {
                        current += line.Substring(starti, i - starti);
                        starti = i + 1;

                        row.Add(current);
                        current = "";
                    }
                }

                current += line.Remove(0, starti);
                starti = 0;

                if (!inString)
                {
                    row.Add(current);
                    current = "";
                    break;
                }
            }

            return row.ToArray();
        }
    }
}
