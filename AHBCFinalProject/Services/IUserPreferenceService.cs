using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IUserPreferenceService
    {
        Task<UserPreferencesViewModel> GetUserPreferencesFromId();
        Task SetUserPreferences(UserPreferencesViewModel viewModel);
        UpdateUserViewModel GetUpdatedPreferenceView(UserPreferencesViewModel prefModel);
    }
}