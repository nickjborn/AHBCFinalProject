﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using AHBCFinalProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AHBCFinalProject.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IMealPlanHistoryService _mealPlanHistoryService;
        private readonly IComplexSearchService _complexSearchService;
        private readonly IRecipeByIdService _recipeByIdService;

        public RecipeController(
            IMealPlanHistoryService mealPlanHistoryService,
            IComplexSearchService complexSearchService,
            IRecipeByIdService recipeByIdService)
        {
            _mealPlanHistoryService = mealPlanHistoryService;
            _complexSearchService = complexSearchService;
            _recipeByIdService = recipeByIdService;
        }

        public async Task<IActionResult> ViewRecipes()
        {
            var viewModel = await _complexSearchService.GetWeekOfRecipes();
           _mealPlanHistoryService.AddMealPlanToHistory(viewModel);

            return View(viewModel);
        }

        public async Task<IActionResult> ViewRecipe(string id)
        {
            var viewModel = await _recipeByIdService.GetRecipeVMById(id);

            return View(viewModel);
        }
    }
}