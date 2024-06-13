using System.ComponentModel.DataAnnotations;

namespace Calorie_Macro_Counter.Models
{
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }

        
        public string Name { get; set; }

        public int Quantity { get; set; }   

        public double Calories { get; set; }

        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fat { get; set; }
    }
}
