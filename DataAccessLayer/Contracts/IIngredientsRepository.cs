using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Models;

namespace DataAccessLayer.Contracts
{
    public interface IIngredientsRepository
    {
        public Task AddIngredient(Ingredient ingredient);
        public Task<List<Ingredient>> GetIngredients(string? name = "");
        public Task DeleteIngredient(Ingredient ingredient);
    }
}
