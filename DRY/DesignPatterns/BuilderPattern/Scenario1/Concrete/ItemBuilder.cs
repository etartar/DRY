namespace DRY.DesignPatterns.BuilderPattern.Scenario1.Concrete
{
    public class ItemBuilder
    {
        public string Name { get; private set; }
        public int Amount { get; private set; }

        public ItemBuilder SetItemName(string itemName)
        {
            Name = itemName;
            return this;
        }

        public ItemBuilder SetAmount(int amount)
        {
            Amount = amount;
            return this;
        }

        public Item Builder()
        {
            return new Item(Name, Amount);
        }
    }
}
