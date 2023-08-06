using Abp.Application.Services.Dto;

namespace MyEcommerceApp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

