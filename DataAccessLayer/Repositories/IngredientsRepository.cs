using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccessLayer.Contracts;
using DomainModel.Models;

namespace DataAccessLayer.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        public async Task AddIngredient(Ingredient ingredient)
        {
            string query = @"INSERT INTO Ingredients (Name, Type, Weight, KcalPer100g, PricePer100g) VALUES (@Name, @Type, @Weight, @KcalPer100g, @PricePer100g)";
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                // Add ingredient to database
                await connection.ExecuteAsync(query, ingredient);
            }
        }

        public async Task<List<Ingredient>> GetIngredients(string? name = "")
        {
            string query = "select * from Ingredients";

            if (!string.IsNullOrEmpty(name)) 
            {
                query += $" where Name like '{name}%'";
            }

            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                return (await connection.QueryAsync<Ingredient>(query)).ToList();
            }
        }
    }
}
