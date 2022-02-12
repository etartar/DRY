namespace DRY.DesignPatterns.BuilderPattern.Scenario1.Concrete
{
    public class Item
    {
        public Item(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }

        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
