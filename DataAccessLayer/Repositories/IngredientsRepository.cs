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

            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    // Add ingredient to database
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch (SqlException ex)
            {
                string errorMessage = "";
                if (ex.Number == 2627) // Unique constraint error number
                {
                    errorMessage = $"An ingredient '{ingredient.Name}' already exists.";
                }
                else
                {
                    errorMessage = "An error occurred in the database.";
                }

                Logger.LogError(errorMessage, DateTime.Now);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while adding ingredient";
                // TODO: Show error message to the user
                Logger.LogError(errorMessage, DateTime.Now);

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


        public async Task DeleteIngredient(Ingredient ingredient)
        {
            string query = @$"DELETE FROM Ingredients where Id = {ingredient.Id}";
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
            {
                // Add ingredient to database
                await connection.ExecuteAsync(query, ingredient);
            }
        }

        public async Task EditIngredient(Ingredient ingredient)
        {
            string query = @$"UPDATE Ingredients
                                           SET Name = @Name, Type = @Type, Weight = @Weight, KcalPer100g = @KcalPer100g, PricePer100g = @PricePer100g
                                           WHERE Id = @Id";

            try
            {
                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    // Add ingredient to database
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch (SqlException ex)
            {
                string errorMessage = "";
                if (ex.Number == 2627) // Unique constraint error number
                {
                    errorMessage = $"An ingredient with this name already exists, that's why edit to '{ingredient.Name}' is not possible.";
                }
                else
                {
                    errorMessage = "An error occurred in the database.";
                }
                Logger.LogError(errorMessage, DateTime.Now);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happend while editing ingredient";
                Logger.LogError(errorMessage, DateTime.Now);
            }
        }
    }
}
