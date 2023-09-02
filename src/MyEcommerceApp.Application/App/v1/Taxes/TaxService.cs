using MyEcommerceApp.App.Taxes;
using MyEcommerceApp.App.Taxes.Dto;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.v1.Taxes
{    
    public class TaxService: MyEcommerceAppAppServiceBase, ITaxService
    {
        private readonly ITaxManager _taxManager;
        public TaxService(ITaxManager taxManager)
        {
            _taxManager = taxManager;
        }

        /// <summary>
        /// Create a new tax
        /// </summary>
        /// <param name="input"><seealso cref="CreateNewTaxInput"/></param>
        /// <returns></returns>
        public async Task<TaxOutput> CreateAsync(CreateNewTaxInput input)
        {
            input.TenantId = AbpSession.TenantId;
            input.CreatorUserId = AbpSession.UserId;

            return await _taxManager.CreateAsync(input);
        }


    }
}
