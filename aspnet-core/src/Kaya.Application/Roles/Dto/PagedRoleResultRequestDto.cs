﻿using Abp.Application.Services.Dto;

namespace Kaya.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

