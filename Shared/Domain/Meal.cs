using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Shared.Domain
{
    public class Meal : BaseDomain
    {
        public string Food { get; set; }
        public string Drink { get; set; }
        public double Price { get; set; }
    }
}
