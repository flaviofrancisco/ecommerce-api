using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using MyEcommerceApp.App.Taxes.Dto;
using System;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using System.Linq;

namespace MyEcommerceApp.App.Taxes
{
    public class TaxManager : ITaxManager
    {
        private readonly IRepository<Tax, Guid> _taxRepository;
        
        public TaxManager(IRepository<Tax, Guid> taxRepository)
        {
            _taxRepository = taxRepository;            
        }

        public async Task<Tax> CreateAsync(Tax input)
        {
            AssertTaxIsValid(input);

            input.Id = Guid.NewGuid();
            input.CreationDateTime = DateTime.Now;
            input.CreatorUserId = input.CreatorUserId;
            input.TenantId= input.TenantId;

           return await _taxRepository.InsertAsync(input);
        }

        public async Task DeleteAsync(Tax input)
        {
            input.IsDeleted = true;
            input.DeletionTime = DateTime.Now;
            input.DeleterUserId = input.DeleterUserId;
            await _taxRepository.DeleteAsync(input);
        }

        public async Task<PagedResultDto<Tax>> GetAllAsync(PagedTaxResultRequestInput input, int? tenantId)
        {
            var query = _taxRepository.GetAll().OrderBy(input.Sorting);            

            var totalCount = await query.CountAsync();

            var items = await query.Skip(input.SkipCount * input.MaxResultCount).Take(input.MaxResultCount).ToListAsync();

            return new PagedResultDto<Tax>(totalCount, items);                
        }

        public async Task<Tax> GetAsync(Guid id)
        {
            return await _taxRepository.GetAsync(id);
        }

        public async Task<Tax> UpdateAsync(Tax input)
        {
            AssertTaxIsValid(input);
            input.LastModificationDateTime = DateTime.Now;
            input.LastModifierUserId = input.LastModifierUserId;
            input.TenantId = input.TenantId;
            return await _taxRepository.UpdateAsync(input);
        }

        private void AssertTaxIsValid(Tax input)
        {
            if (string.IsNullOrWhiteSpace(input.Name))
                throw new ArgumentNullException(nameof(input.Name));

            if (string.IsNullOrWhiteSpace(input.Acronym))
                throw new ArgumentNullException(nameof(input.Acronym));
        }
    }
}
