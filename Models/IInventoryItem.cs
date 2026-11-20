namespace RPGInventory.Models
{
    public interface IInventoryItem
    {
        string Name { get; }
        double GetWeight();
        double GetCost();
        IInventoryItem Clone();
        void DisplayInfo(int indent = 0);
    }
}