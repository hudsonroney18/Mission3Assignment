//this is a program that keeps track of food items inputted and allows you to see them

namespace Mission3CrashCourse;
internal class Program
{
    public static void Main(string[] args)
    {
        List<FoodItem> foodItems = new List<FoodItem>();
        bool running = true;

        while (running)
        {
            Console.WriteLine(
                $"Welcome to the food item program!\n 1.Add a food item\n 2.Delete a food item\n 3.Print food items\n 4.Exit the program");
            Console.Write("Enter your option: ");
            string optionSelect = Console.ReadLine();

            switch (optionSelect)
            {
                case "1":
                    Console.WriteLine("Enter the food item name: ");
                    string foodName;
                    do
                    {
                        foodName = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(foodName))
                        {
                            Console.WriteLine("Food name cannot be empty. Please enter a valid food name:");
                        }
                    } while (string.IsNullOrWhiteSpace(foodName));

                    Console.WriteLine("Enter the food item category: ");
                    string foodCategory;
                    do
                    {
                        foodCategory = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(foodCategory))
                        {
                            Console.WriteLine("Food category cannot be empty. Please enter a valid category:");
                        }
                    } while (string.IsNullOrWhiteSpace(foodCategory));

                    Console.WriteLine("Enter the food item quantity: ");
                    string foodQuantity;
                    do
                    {
                        foodQuantity = Console.ReadLine();
                        if (!int.TryParse(foodQuantity, out int parsedquanitity) || parsedquanitity < 0)
                        {
                            Console.WriteLine("Quantity must be a valid non-negative number. Please enter a valid quantity:");
                            foodQuantity = null;
                        }
                    } while (foodQuantity == null);

                    Console.WriteLine("Enter the food item expiration date (e.g., YYYY-MM-DD): ");
                    string foodExpirationDate = Console.ReadLine();

                    FoodItem foodItem = new FoodItem(foodName, foodCategory, foodQuantity, foodExpirationDate);
                    foodItems.Add(foodItem);
                    Console.WriteLine("Food item added successfully!");
                    break;

                case "2":
                    if (foodItems.Count == 0)
                    {
                        Console.WriteLine("No food items available to delete.");
                        break;
                    }

                    Console.WriteLine("Enter the food name to delete: ");
                    string deleteName = Console.ReadLine();
                    int itemsRemoved = foodItems.RemoveAll(item => item.GetFoodName() == deleteName);

                    if (itemsRemoved > 0)
                    {
                        Console.WriteLine("Food item deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No matching food item found.");
                    }
                    break;

                case "3":
                    if (foodItems.Count == 0)
                    {
                        Console.WriteLine("No food items available.");
                    }
                    else
                    {
                        Console.WriteLine("Food items:");
                        foreach (var item in foodItems)
                        {
                            Console.WriteLine(item.GetDetails());
                        }
                    }
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}
