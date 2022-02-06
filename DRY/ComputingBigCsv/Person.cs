using CsvHelper.Configuration.Attributes;
using System;

namespace DRY.ComputingBigCsv
{
    public class Person
    {
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public string FirstName { get; set; }
        [Index(2)]
        public string LastName { get; set; }
        [Index(3)]
        public double Salary { get; set; }
    }
}
