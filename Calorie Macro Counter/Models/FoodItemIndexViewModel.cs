using System.Collections.Generic;
using Calorie_Macro_Counter.Models; // Adjust namespace as needed

namespace Calorie_Macro_Counter.Models
{
    public class FoodItemIndexViewModel
    {
        public List<FoodItem> FoodItems { get; set; }
        public int TotalCalories { get; set; }
        public int TotalProtein { get; set; }
        public int TotalFat { get; set; }
        public int TotalCarbohydrates { get; set; }
    }
}
