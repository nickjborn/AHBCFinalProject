using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IFavoriteMealsStore
    {
        Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMeals();
        Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMealsReadyIn1To2Hrs();
        Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMealsReadyIn30Min();
        Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMealsReadyIn1Hr();
        Task<IEnumerable<FavoriteMealDALModel>> SelectAllFavMealsReadyInMoreThan2Hrs();
        Task<FavoriteMealDALModel> SelectAFavMeal(string recipeId);
        Task<bool> InsertAFaveMeal(FavoriteMealDALModel dalModel);
        Task<bool> DeleteAFaveMeal(string recipeId);
        Task<bool> UpdateFavoriteMealComments(FavoriteMealDALModel dalModel);
    }
}

