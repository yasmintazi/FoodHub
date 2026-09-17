using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Custom : BaseDomain
    {
        public List<Ingredient> Ingredients { get; set; }
        public virtual Ingredient Ingredient { get; set; }
        public virtual Drink Drink { get; set; }
        public double CustomPrice { get; set; }
    }
}
