using Module_2_KnowledgeCheck;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<CatFood>(); // Replaced MyClass with CatFood
for (int i = 0; i < numberOfRecords; i++)
{
    var catFood = new CatFood();

    Console.WriteLine("Enter the name: ");
    catFood.Name = Console.ReadLine();

    Console.WriteLine("Enter the price: ");
    catFood.Price = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter the quantity: ");
    catFood.Quantity = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the description: ");
    catFood.Description = Console.ReadLine();

    // Add any additional CatFood-specific properties here

    recordList.Add(catFood);
}

// Print out the list of records using Console.WriteLine()
foreach (var item in recordList)
{
    Console.WriteLine(item.ToString());
}

