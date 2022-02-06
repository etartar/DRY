using CsvHelper;
using CsvHelper.Configuration;
using DRY.Disposable;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.ComputingBigCsv
{
    public class CsvReaderProgram
    {
        public static void CsvReadWithoutPLINQ()
        {
            using (var po = new PerformanceOperation("CsvReadWithoutPLINQ"))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    HasHeaderRecord = true,
                    Comment = '#',
                    AllowComments = true,
                    Delimiter = ","
                };

                using var streamReader = File.OpenText("people.csv");
                using var csvReader = new CsvReader(streamReader, csvConfig);
                var peoples = csvReader.GetRecords<Person>().ToList();
                Console.WriteLine($"People count : {peoples.Count()}");
            }
        }

        public static void CsvReadWithPLINQ()
        {
            using (var po = new PerformanceOperation("CsvReadWithPLINQ"))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    HasHeaderRecord = true,
                    Comment = '#',
                    AllowComments = true,
                    Delimiter = ","
                };

                using var streamReader = File.OpenText("people.csv");
                using var csvReader = new CsvReader(streamReader, csvConfig);
                var peoples = csvReader.GetRecords<Person>().AsParallel().ToList();
                Console.WriteLine($"People count : {peoples.Count()}");
            }
        }
    }
}
