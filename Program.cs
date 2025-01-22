//this is a program that keeps track of food items inputted and allows you to see them

namespace Mission3CrashCourse;
internal class Program
{
    public static void Main(string[] args)
    {
        List<FoodItem> foodItems = new List<FoodItem>();
        bool running = true;

        while (running == true)
        {
            Console.WriteLine(
                $"Welcome to the food item program!\n 1.Add a food item\n 2.Delete a food item\n 3.Print food items\n 4.Exit the program");
            string optionSelect = Console.ReadLine();

            switch (optionSelect)
            {
                case "1":
                    Console.WriteLine("Enter the food item name: ");
                    string foodName = Console.ReadLine();
                    Console.WriteLine("Enter the food item category: ");
                    string foodCategory = Console.ReadLine();
                    Console.WriteLine("Enter the food item quantity: ");
                    string foodQuantity = Console.ReadLine();
                    Console.WriteLine("Enter the food item Expiration Date: ");
                    string foodExpirationDate = Console.ReadLine();
                    FoodItem foodItem = new FoodItem(foodName, foodCategory, foodQuantity, foodExpirationDate);
                    foodItems.Add(foodItem);
                    break;
                case "2":
                    Console.WriteLine("Enter the food name to delete: ");
                    string deleteName = Console.ReadLine();
                    foodItems.RemoveAll(item => item.GetFoodName() == deleteName);
                    Console.WriteLine("Food item deleted if it existed.");

                    break;
                case "3":
                    Console.WriteLine("Food items:");
                    foreach (var item in foodItems)
                    {
                        Console.WriteLine(item.GetDetails());
                    }

                    break;
                case "4": // Exit the program
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
