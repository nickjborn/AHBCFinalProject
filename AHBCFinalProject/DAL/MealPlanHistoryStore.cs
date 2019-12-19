
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using Dapper;

namespace AHBCFinalProject.DAL
{
    public class MealPlanHistoryStore : IMealPlanHistoryStore
    {
        private readonly Database _config;

        public MealPlanHistoryStore(AHBCFinalProjectConfiguration config)
        {
            _config = config.Database;
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
    }
}