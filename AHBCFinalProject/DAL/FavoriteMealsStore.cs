using AHBCFinalProject.Services;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public class FavoriteMealsStore : IFavoriteMealsStore
    {
        private readonly Database _config;
        private readonly IUserIdService _userIdService;

        public FavoriteMealsStore(AHBCFinalProjectConfiguration config, IUserIdService userIdService)
        {
            _config = config.Database;
            _userIdService = userIdService;
        }

        public async Task<bool> DeleteAFaveMeal(string recipeId)
        {
            var sql = @"DELETE FROM FavoriteMeals WHERE RecipeId = @recipeId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = await connection.ExecuteAsync(sql, new { RecipeId = recipeId });
                return true;
            }
        }

        public async Task<bool> InsertAFaveMeal(FavoriteMealDALModel dalModel)
        {
            var Id = _userIdService.getUserId();
            var sql = $@"INSERT INTO FavoriteMeals (Id, RecipeID, MealName, ReadyInMinutes, AdditionalComments) 
                            VALUES ({Id}, {dalModel.RecipeID}, '{dalModel.MealName}',{dalModel.ReadyInMinutes}, '{dalModel.AdditionalComments}')";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.ExecuteAsync(sql, dalModel);

                return true;
            }
        }

        public async Task<FavoriteMealDALModel> SelectAFavMeal(string recipeId)
        {
            var sql = @"SELECT * from FavoriteMeals where RecipeId = @RecipeId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = await connection.QueryFirstOrDefaultAsync<FavoriteMealDALModel>(sql, new { recipeId = recipeId });
                return result;
            }
        }

        public async Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMeals()
        {
            var userId = _userIdService.getUserId();
            var sql = @"SELECT * FROM FavoriteMeals WHERE Id = @Id ORDER BY MealName ASC";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryAsync<FavoriteMealDALModel>(sql, new { Id = userId }) ?? new List<FavoriteMealDALModel>();
                return results;
            }
        }

        public async Task<bool> UpdateFavoriteMealComments(FavoriteMealDALModel dalModel)
        {
            var sql = $@"UPDATE FavoriteMeals SET AdditionalComments = @{nameof(dalModel.AdditionalComments)} WHERE Id = @{nameof(dalModel.Id)} and RecipeID = @{nameof(dalModel.RecipeID)}";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.ExecuteAsync(sql, dalModel);

                return true;
            }
        }

        public async Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMealsReadyIn1To2Hrs()
        {
            var userId = _userIdService.getUserId();
            var sql = @"SELECT * FROM FavoriteMeals WHERE Id = @Id AND ReadyInMinutes BETWEEN 60 AND 120 ORDER BY MealName ASC";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryAsync<FavoriteMealDALModel>(sql, new { Id = userId }) ?? new List<FavoriteMealDALModel>();
                return results;
            }
        }

        public async Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMealsReadyIn30Min()
        {
            var userId = _userIdService.getUserId();
            var sql = @"SELECT * FROM FavoriteMeals WHERE Id = @Id AND ReadyInMinutes BETWEEN 0 AND 30 ORDER BY MealName ASC";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryAsync<FavoriteMealDALModel>(sql, new { Id = userId }) ?? new List<FavoriteMealDALModel>();
                return results;
            }
        }

        public async Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMealsReadyIn1Hr()
        {
            var userId = _userIdService.getUserId();
            var sql = @"SELECT * FROM FavoriteMeals WHERE Id = @Id AND ReadyInMinutes BETWEEN 30 AND 60 ORDER BY MealName ASC";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryAsync<FavoriteMealDALModel>(sql, new { Id = userId }) ?? new List<FavoriteMealDALModel>();
                return results;
            }
        }

        public async Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMealsReadyInMoreThan2Hrs()
        {
            var userId = _userIdService.getUserId();
            var sql = @"SELECT * FROM FavoriteMeals WHERE Id = @Id AND ReadyInMinutes BETWEEN 30 AND 60 ORDER BY MealName ASC";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryAsync<FavoriteMealDALModel>(sql, new { Id = userId }) ?? new List<FavoriteMealDALModel>();
                return results;
            }
        }
    }
}