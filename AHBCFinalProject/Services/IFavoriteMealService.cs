using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IFavoriteMealService
    {
        Task<FavoriteMealsViewModel> InsertAFavoriteMeal(string recipeId);
        Task<FavoriteMealsViewModel> DeleteAFavoriteMeal(string recipeId);
        Task<FavoriteMealsViewModel> SelectAllFavoriteMeals();
        Task<FavoriteMealsViewModel> FMReadyIn1To2Hrs();
        Task<FavoriteMealsViewModel> FMReadyIn30Min();
        Task<FavoriteMealsViewModel> FMReadyIn1Hrs();
        Task<FavoriteMealsViewModel> FMReadyInMoreThan2Hrs();
        Task<ViewFavoriteMealViewModel> SelectAFavoriteMeal(string recipeId);
        Task<ViewFavoriteMealViewModel> UpdateFavoriteMealComments(ViewFavoriteMealViewModel model);
    }
}