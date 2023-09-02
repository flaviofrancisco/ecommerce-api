using Abp.Application.Services.Dto;
using System;

namespace MyEcommerceApp.App.Taxes.Dto
{
    /// <summary>
    /// Represents the input to create a new tax
    /// </summary>
    public class CreateNewTaxInput : EntityDto<Guid>
    {
        /// <summary>
        /// Name of the tax
        /// </summary>
        public string Name { get; set; }
        public string Acronym { get; set; }
        /// <summary>
        /// Value in percentage
        /// </summary>        
        public long? CreatorUserId { get; set; }
        public int? TenantId { get; set; }  
        public decimal Rate { get; set; } = 0.0m;
    }
}
