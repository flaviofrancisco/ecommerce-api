using Abp.Application.Services.Dto;
using Abp.Authorization;
using MyEcommerceApp.App.Products;
using MyEcommerceApp.App.Products.Dto;
using MyEcommerceApp.App.Taxes;
using MyEcommerceApp.App.Taxes.Dto;
using MyEcommerceApp.App.v1.Taxes.Dto;
using MyEcommerceApp.Authorization;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.v1.Taxes
{
    /// <summary>
    /// This service is responsible for managing taxes
    /// </summary>
    [AbpAuthorize(PermissionNames.Pages_Administration)]
    public class TaxAppService: MyEcommerceAppAppServiceBase, ITaxService
    {
        private readonly ITaxManager _taxManager;

        public TaxAppService(ITaxManager taxManager)
        {
            _taxManager = taxManager;
        }

        public async Task<TaxDto> CreateAsync(CreateTaxDto input)
        {
            var tax = ObjectMapper.Map<Tax>(input);
            tax.TenantId = AbpSession.TenantId;
            tax.CreatorUserId = AbpSession.UserId;
            var createdTax  =await _taxManager.CreateAsync(tax);
            return ObjectMapper.Map<TaxDto>(createdTax);            
        }

        public async Task DeleteAsync(DeleteTaxDto input)
        {                       
            var tax = ObjectMapper.Map<Tax>(input);
            tax.TenantId = AbpSession.TenantId;
            tax.DeleterUserId = AbpSession.UserId;
            await _taxManager.DeleteAsync(tax);
        }

        public async Task<PagedResultDto<TaxDto>> GetAllAsync(PagedTaxResultRequestDto input)
        {
            var request = ObjectMapper.Map<PagedTaxResultRequestInput>(input);
                        
            var taxes = await _taxManager.GetAllAsync(request,AbpSession.TenantId);

            return new PagedResultDto<TaxDto>
            {
                TotalCount = taxes.TotalCount,
                Items = ObjectMapper.Map<List<TaxDto>>(taxes.Items)
            };
        }

        public async Task<TaxDto> GetAsync(GetTaxDto input)
        {
            var tax =  await _taxManager.GetAsync(input.Id);
            tax.TenantId = AbpSession.TenantId;            
            return ObjectMapper.Map<TaxDto>(tax);
        }

        public async Task<TaxDto> UpdateAsync(UpdateTaxDto input)
        {
            var tax = ObjectMapper.Map<Tax>(input);
            tax.TenantId = AbpSession.TenantId;            
            var updatedTax = await _taxManager.UpdateAsync(tax);           
            return ObjectMapper.Map<TaxDto>(updatedTax);
        }
    }
}
