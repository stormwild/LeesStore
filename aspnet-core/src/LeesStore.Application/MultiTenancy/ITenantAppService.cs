﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LeesStore.MultiTenancy.Dto;

namespace LeesStore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

