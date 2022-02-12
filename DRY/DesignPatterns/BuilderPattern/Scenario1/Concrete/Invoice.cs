using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY.DesignPatterns.BuilderPattern.Scenario1.Concrete
{
    public class Invoice
    {
        public Invoice(string companyName, string vat, DateTime startDate, double amount, double tax, IList<Item> ıtems, string othersInformations)
        {
            CompanyName = companyName;
            Vat = vat;
            StartDate = startDate;
            Amount = amount;
            Tax = tax;
            Items = ıtems;
            OthersInformations = othersInformations;
        }

        public string CompanyName { get; set; }
        public string Vat { get; set; }
        public DateTime StartDate { get; set; }
        public double Amount { get; set; }
        public double Tax { get; set; }
        public IList<Item> Items { get; set; }
        public string OthersInformations { get; set; }
    }
}
