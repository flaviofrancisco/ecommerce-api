using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using MyEcommerceApp.App.Taxes.Dto;
using System;
using System.Threading.Tasks;

namespace MyEcommerceApp.App.Taxes
{
    public class TaxManager : ITaxManager
    {
        private readonly IRepository<Tax, Guid> _taxRepository;
        private readonly IObjectMapper _objectMapper;

        public TaxManager(IRepository<Tax, Guid> taxRepository, IObjectMapper objectMapper)
        {
            _taxRepository = taxRepository;
            _objectMapper = objectMapper;
        }

        public async Task<TaxOutput> CreateAsync(CreateNewTaxInput input)
        {

            AssertTaxIsValid(input);

            var newTax = _objectMapper.Map<Tax>(input); 

            newTax .Id = Guid.NewGuid();
            newTax.CreationDateTime = DateTime.Now;
            newTax.CreatorUserId = input.CreatorUserId;
            newTax.TenantId= input.TenantId;

           var createdTax = await _taxRepository.InsertAsync(newTax);

            return _objectMapper.Map<TaxOutput>(createdTax);
        }

        private void AssertTaxIsValid(CreateNewTaxInput input)
        {
            if (string.IsNullOrWhiteSpace(input.Name))
                throw new ArgumentNullException(nameof(input.Name));

            if (string.IsNullOrWhiteSpace(input.Acronym))
                throw new ArgumentNullException(nameof(input.Acronym));
        }
    }
}
