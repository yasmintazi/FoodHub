using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Ingredient : BaseDomain
    {
        public string Name { get; set; }
        public double Price { get; set; } 
    }
}
