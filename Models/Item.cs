namespace RPGInventory.Models
{
    public class Item : IInventoryItem
    {
        public string Name { get; }
        public double Weight { get; }
        public double Cost { get; }

        public Item(string name, double weight, double cost)
        {
            Name = name;
            Weight = weight;
            Cost = cost;
        }

        public double GetWeight() => Weight;
        public double GetCost() => Cost;

        public IInventoryItem Clone()
        {
            return new Item(Name, Weight, Cost);
        }

        public void DisplayInfo(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}- {Name} (вес: {Weight} кг, стоимость: {Cost} золотых)");
        }
    }
}