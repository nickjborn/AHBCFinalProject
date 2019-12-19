
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using Dapper;
using AHBCFinalProject.Services;
using AHBCFinalProject.SpoonacularServices;

namespace AHBCFinalProject.DAL
{
    public class MealPlanHistoryStore : IMealPlanHistoryStore
    {
        private readonly Database _config;
        private readonly IUserIdService _userIdService;
        private readonly IComplexSearchStore _complexSearchStore;

        public MealPlanHistoryStore(AHBCFinalProjectConfiguration config, IUserIdService userIdService, IComplexSearchStore complexSearchService)
        {
            _config = config.Database;
            _userIdService = userIdService;
            _complexSearchStore = complexSearchService;
        }

        public async Task<bool> InsertWeeklyMealPlan(MealPlanHistoryViewModel dalModel)
        {
            var sql = $@"INSERT INTO AllMealPlans (Id, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, StartDate, EndDate) 
                            VALUES (@{nameof(dalModel.Id)}, @{nameof(dalModel.Sunday)}, @{nameof(dalModel.Monday)},@{nameof(dalModel.Tuesday)},@{nameof(dalModel.Wednesday)},@{nameof(dalModel.Thursday)},@{nameof(dalModel.Friday)},@{nameof(dalModel.Saturday)}, @{nameof(dalModel.StartDate)}, @{nameof(dalModel.EndDate)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.ExecuteAsync(sql, dalModel);

                return true;
            }
        }

        public async Task<IEnumerable<MealPlanHistoryDALModel>> ViewWeeklyMealPlan(ViewMealPlanViewModel dalModel)
        {
            var sql = $@"SELECT * FROM AllMealPlans WHERE Id = @{nameof(dalModel.Id)} AND '@{nameof(dalModel.StartDate)}' BETWEEN '@{nameof(dalModel.StartDate)}' AND '@{nameof(dalModel.TodaysDate)}'";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryAsync<MealPlanHistoryDALModel>(sql, dalModel);
                return results;
            }
        }

        public async Task<MealPlanHistoryDALModel> ViewCurrentMealPlan(CurrentMPViewModel model)
        {
            var sql = $@"SELECT * FROM AllMealPlans WHERE Id = @{nameof(model.Id)} AND @{nameof(model.TodaysDate)} BETWEEN StartDate AND EndDate";
            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryFirstAsync<MealPlanHistoryDALModel>(sql, model);
 
                return results;
            }
        }

        public async Task<MealPlanHistoryDALModel> SearchPastMealPlans(ViewMealPlanViewModel model)
        {
            var sql = $@"SELECT * FROM AllMealPlans WHERE Id = @{nameof(model.Id)} AND @{nameof(model.StartDate)} BETWEEN StartDate AND EndDate";
            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryFirstAsync<MealPlanHistoryDALModel>(sql, model);

                return results;
            }
        }

        public async Task UpdateOneResult(string day)
        {
            
            var userId = _userIdService.getUserId();
            var now = DateTime.Today;
            var newMeal = await _complexSearchStore.GetOneRecipeComplexSearch();
           // var newmealId = int.Parse(newMeal.id);
            var newmealId = 15357; //example meal id
            var sql = $@"UPDATE AllMealPlans SET {day} = {newmealId} WHERE Id = {userId}"; /* AND '{now}' BETWEEN StartDate AND EndDate*/
            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = await connection.QueryFirstAsync<MealPlanHistoryDALModel>(sql);
            }
        }
    }
}