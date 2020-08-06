﻿using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace DA.ProjectManagement.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
