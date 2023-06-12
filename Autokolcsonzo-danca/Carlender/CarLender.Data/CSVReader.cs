using System.Collections.Generic;
using System.IO;

namespace CarLender.Types
{
    class CSVReader
    {
        public static List<Dictionary<string, string>> LoadData(StreamReader sr, char separator)
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
