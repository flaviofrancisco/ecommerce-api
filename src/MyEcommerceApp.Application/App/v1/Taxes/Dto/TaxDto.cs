using Abp.Application.Services.Dto;
using System;

namespace MyEcommerceApp.App.v1.Taxes.Dto
{
    public class TaxDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Acronym { get; set; }
        public decimal Rate { get; set; } = 0.0m;
        public long? LastModifierUserId { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime? LastUpateDateTime { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int? TenantId { get; set; }
    }
}
