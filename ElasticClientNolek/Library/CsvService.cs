using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace Library
{
    public static class CsvService
    {
        public static List<T> ImportDataFromCsv<T>(string filePath)
        {
            using (var sr = new StreamReader(filePath))
            using (var csv = new CsvReader(new CsvParser(sr, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" }))) 
            { 
                return csv.GetRecords<T>().ToList();
            }
        }
    }
}
