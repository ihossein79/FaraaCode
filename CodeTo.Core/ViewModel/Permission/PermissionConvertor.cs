﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTo.Domain.Entities.Users;

namespace CodeTo.Core.ViewModel.Permission
{
    public static class PermissionConvertor
    {

        #region ShowRole
        public static ShowRoleViewModel ToShowRoleViewModel(this Role r)
        {
            return new ShowRoleViewModel
            {
                Id = r.Id,
                Name = r.RoleTitle
            };
        }

        #endregion

        #region RolePermission

        public static RolePermissionAddOrEditViewModel ToRolePermissionAddEditViewModel(this Role r)
        {
            return new RolePermissionAddOrEditViewModel
            {
                Id = r.Id,
                Name = r.RoleTitle,
            };
        }

        #endregion
    }
}
