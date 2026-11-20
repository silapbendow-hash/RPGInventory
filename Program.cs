using RPGInventory.Models;

namespace RPGInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== ИНВЕНТАРЬ RPG-ИГРЫ ===\n");

            // Сценарий 1: Создание предметов
            Console.WriteLine("--- Сценарий 1: Создание предметов ---");
            var sword = new Item("Меч", 3.5, 500);
            var potion = new Item("Зелье здоровья", 0.5, 50);
            var book = new Item("Книга заклинаний", 1.0, 200);
            
            Console.WriteLine($"Создан предмет: {sword.Name} (вес: {sword.GetWeight()} кг, стоимость: {sword.GetCost()} золотых)");
            Console.WriteLine($"Создан предмет: {potion.Name} (вес: {potion.GetWeight()} кг, стоимость: {potion.GetCost()} золотых)");
            Console.WriteLine($"Создан предмет: {book.Name} (вес: {book.GetWeight()} кг, стоимость: {book.GetCost()} золотых)");
            Console.WriteLine();

            // Сценарий 2: Создание контейнеров
            Console.WriteLine("--- Сценарий 2: Создание контейнеров ---");
            var smallBag = new Container("Малый рюкзак");
            smallBag.Add(sword);
            smallBag.Add(potion);
            
            Console.WriteLine();
            
            var largeChest = new Container("Большой сундук");
            largeChest.Add(smallBag);
            largeChest.Add(book);
            
            Console.WriteLine();

            // Сценарий 3: Отображение структуры инвентаря
            Console.WriteLine("--- Сценарий 3: Структура инвентаря ---");
            largeChest.DisplayInfo();
            Console.WriteLine();

            // Сценарий 4: Расчёт веса и стоимости
            Console.WriteLine("--- Сценарий 4: Расчёт ресурсов ---");
            Console.WriteLine($"Общий вес \"{smallBag.Name}\": {smallBag.GetWeight()} кг");
            Console.WriteLine($"Общая стоимость \"{smallBag.Name}\": {smallBag.GetCost()} золотых");
            Console.WriteLine();
            Console.WriteLine($"Общий вес \"{largeChest.Name}\": {largeChest.GetWeight()} кг");
            Console.WriteLine($"Общая стоимость \"{largeChest.Name}\": {largeChest.GetCost()} золотых");
            Console.WriteLine();

            // Сценарий 5: Клонирование предмета
            Console.WriteLine("--- Сценарий 5: Клонирование предмета ---");
            var clonedPotion = (Item)potion.Clone();
            Console.WriteLine($"Оригинал: {potion.Name} (вес: {potion.GetWeight()} кг, стоимость: {potion.GetCost()} золотых)");
            Console.WriteLine($"Клон: {clonedPotion.Name} (вес: {clonedPotion.GetWeight()} кг, стоимость: {clonedPotion.GetCost()} золотых)");
            Console.WriteLine($"Объекты независимы: {!ReferenceEquals(potion, clonedPotion)}");
            Console.WriteLine();

            // Сценарий 6: Клонирование контейнера
            Console.WriteLine("--- Сценарий 6: Клонирование контейнера ---");
            var clonedBag = (Container)smallBag.Clone();
            Console.WriteLine("Клонированный контейнер:");
            clonedBag.DisplayInfo();
            Console.WriteLine($"Общий вес клона: {clonedBag.GetWeight()} кг");
            Console.WriteLine($"Общая стоимость клона: {clonedBag.GetCost()} золотых");

            Console.WriteLine("\n=== ДЕМО ЗАВЕРШЕНО ===");
            Console.ReadLine();
        }
    }
}