using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Weight { get; set; }
        public decimal KcalPer100g { get; set; }
        public decimal PricePer100g { get; set; }

        public Ingredient(string name, string type, decimal weight, decimal kcalPer100g, decimal pricePer100g)
        {
            Name = name;
            Type = type;
            Weight = weight;
            KcalPer100g = kcalPer100g;
            PricePer100g = pricePer100g;
        }

        public Ingredient() {}
    }
}
