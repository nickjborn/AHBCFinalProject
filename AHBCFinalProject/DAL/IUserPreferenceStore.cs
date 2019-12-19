﻿using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IUserPreferenceStore
    {
        Task<UserPreferenceDALModel> SelectUserPreferences(int userId);
        Task<bool> UpdateUserPreferences(UserPreferenceDALModel dalModel);
        Task CreateNewUserPrefEntry();
    }
}