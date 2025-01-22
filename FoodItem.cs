namespace Mission3CrashCourse;

public class FoodItem
{
    private string foodName;
    private string foodCategory;
    private string quantity;
    private string expirationDate;
    public FoodItem(string foodName, string foodCategory, string quantity, string expirationDate)
    {
        this.foodName = foodName;
        this.foodCategory = foodCategory;
        this.quantity = quantity;
        this.expirationDate = expirationDate;
    }

    public string GetFoodName()
    {
        return foodName;
    }

    public string GetDetails()
    {
        return $"\nFood name - {foodName} \n category: {foodCategory} \n quantity: {quantity} \n expiration date: {expirationDate}\n";
    }
}