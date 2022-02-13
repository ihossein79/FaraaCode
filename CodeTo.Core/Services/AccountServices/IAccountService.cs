﻿using CodeTo.Core.ViewModel.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTo.Core.Services.AccountServices
{
    public interface IAccountService
    {
        Task<bool> RegisterAsync(AccountRegisterVm vm);
        Task<bool> CheckEmailAndPasswordAsync(AccountLoginVm vm);
        Task<bool> IsDuplicatedEmail(string email);
        Task<bool> IsDuplicatedUsername(string username);
        Task<UserDetailVm> GetUserByEmailAsync(string email);
        Task<UserDetailVm> GetUserByIdAsync(int userId);
        Task<bool> ActiveAccountAsync(string activecode);

        #region UserProfile
        Task<UserDetailVm> GetUserInformation(string username);
        Task<UserPanelDataVm> GetUserPanelData(string username);
        Task<EditProfileVm> GetEditPrifileData(string username);
        Task<bool> GetEditProfile(string username, EditProfileVm profile);
        #endregion


    }
}
