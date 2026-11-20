namespace RPGInventory.Models
{
    public class Container : IInventoryItem
    {
        public string Name { get; }
        private List<IInventoryItem> _items = new List<IInventoryItem>();

        public Container(string name)
        {
            Name = name;
        }

        public void Add(IInventoryItem item)
        {
            _items.Add(item);
            Console.WriteLine($"Добавлен предмет \"{item.Name}\" в \"{Name}\"");
        }

        /// <summary>
        /// Composite: Рекурсивный подсчёт веса всех вложенных предметов
        /// </summary>
        public double GetWeight()
        {
            return _items.Sum(item => item.GetWeight());
        }

        /// <summary>
        /// Composite: Рекурсивный подсчёт стоимости
        /// </summary>
        public double GetCost()
        {
            return _items.Sum(item => item.GetCost());
        }

        /// <summary>
        /// Prototype: Глубокое копирование контейнера и всех его содержимых
        /// </summary>
        public IInventoryItem Clone()
        {
            var clone = new Container(Name);
            foreach (var item in _items)
            {
                clone.Add(item.Clone());
            }
            return clone;
        }

        public void DisplayInfo(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}[Контейнер: {Name}]");
            foreach (var item in _items)
            {
                item.DisplayInfo(indent + 2);
            }
        }
    }
}