using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Contracts;
using DomainModel.Models;

namespace DataAccessLayer.Repositories
{
    public class IngredientsTxtRepository : IIngredientsRepository
    {
        string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "IngredientsStorage.txt");
        public void AddIngredient(Ingredient ingredient)
        {
            int id = Math.Abs(Guid.NewGuid().GetHashCode());

            using (StreamWriter sw = File.AppendText(_filePath))
            {
                sw.WriteLine($"{id}|{ingredient.Name}|{ingredient.Type}|{ingredient.Weight}|{ingredient.KcalPer100g}|{ingredient.PricePer100g}");
            }
        }

        public List<Ingredient> GetIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            using (StreamReader sr = File.OpenText(_filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split('|');

                    Ingredient ingredient = new Ingredient();

                    ingredient.Id = int.Parse(values[0]);
                    ingredient.Name = values[1];
                    ingredient.Type = values[2];
                    ingredient.Weight = decimal.Parse(values[3]);
                    ingredient.KcalPer100g = decimal.Parse(values[4]);
                    ingredient.PricePer100g = decimal.Parse(values[5]);

                    ingredients.Add(ingredient);
                }
            }
            return ingredients;
        }
    }
}
