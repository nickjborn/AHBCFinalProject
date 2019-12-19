using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IMealPlanHistoryStore
    {
        Task<MealPlanHistoryDALModel> SearchPastMealPlans(ViewMealPlanViewModel model);
        Task<MealPlanHistoryDALModel> ViewCurrentMealPlan(CurrentMPViewModel model);
        Task<bool> InsertWeeklyMealPlan(MealPlanHistoryViewModel dalModel);
        Task<IEnumerable<MealPlanHistoryDALModel>> ViewWeeklyMealPlan(ViewMealPlanViewModel dalModel);
        Task UpdateOneResult(string day);
    }
}