using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Order : BaseDomain
    {
        public DateTime DateTime { get; set; }
        public virtual Meal Meal { get; set; }
        public int? MealId { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public int? IngredientId { get; set; }
        public int? Ingredient2Id { get; set; }
        public int? Ingredient3Id { get; set; }
        public int? Ingredient4Id { get; set; }
        public int? Ingredient5Id { get; set; }
        public virtual Drink Drink { get; set; }
        public int? DrinkId { get; set; }
        public virtual Sushi Sushi { get; set; }
        public int? SushiId { get; set; }
    }
}
