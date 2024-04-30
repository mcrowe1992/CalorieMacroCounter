using System.ComponentModel.DataAnnotations;

namespace Calorie_Macro_Counter.Models
{
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }

        
        public string Name { get; set; }

        public bool ChickenBreast { get; set; }

        public bool ChickenThigh { get; set; }

        public bool Steak { get; set; }

        public bool BeefGround { get; set; }

        public bool TurkeyGround { get; set; }

        public bool RiceWhite { get; set; }

        public bool RiceBrown { get; set; }

        public bool Broccoli { get; set; }

        public bool Onion { get; set; }

        public bool BellPepper { get; set; }

        public bool Potato { get; set; }

        public bool Egg { get; set; }

        public bool Salad { get; set; }

        public bool CookingOil { get; set; }

        [DataType(DataType.Currency)]
        public double Calories { get; set; }

    }
}
