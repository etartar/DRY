using System;
using System.Collections.Generic;

namespace DRY.DesignPatterns.BuilderPattern.Scenario1.Concrete
{
    public class InvoiceBuilder
    {
        public string CompanyName { get; private set; }
        public string Vat { get; private set; }
        public string OthersInformations { get; private set; }
        public DateTime StartDate { get; private set; } = DateTime.UtcNow;

        private double _amount;
        private double _tax;
        private readonly List<Item> _items;

        public InvoiceBuilder SetCompanyName(string companyName)
        {
            CompanyName = companyName;
            return this;
        }

        public InvoiceBuilder SetVat(string vat)
        {
            Vat = vat;
            return this;
        }

        public InvoiceBuilder SetOthersInformations(string othersInformations)
        {
            OthersInformations = othersInformations;
            return this;
        }

        public InvoiceBuilder SetStartDate(DateTime startDate)
        {
            StartDate = startDate;
            return this;
        }

        public InvoiceBuilder SetItem(Item item)
        {
            _items.Add(item);
            _amount += item.Amount;
            _tax += item.Amount * 0.05;
            return this;
        }

        public Invoice Builder()
        {
            return new Invoice(CompanyName, Vat, StartDate, _amount, _tax, _items, OthersInformations);
        }
    }
}
