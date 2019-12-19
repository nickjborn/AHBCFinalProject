using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IMealPlanHistoryStore
    {
        MealPlanHistoryDALModel SearchPastMealPlans(ViewMealPlanViewModel model);
        MealPlanHistoryDALModel ViewCurrentMealPlan(CurrentMPViewModel model);
        Task<bool> InsertWeeklyMealPlan(MealPlanHistoryViewModel dalModel);
        Task<IEnumerable<MealPlanHistoryDALModel>> ViewWeeklyMealPlan(ViewMealPlanViewModel dalModel);
        MealPlanHistoryDALModel UpdateOneResult(string day);
    }
}