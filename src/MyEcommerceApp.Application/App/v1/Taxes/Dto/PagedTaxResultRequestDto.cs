using Abp.Application.Services.Dto;

namespace MyEcommerceApp.App.v1.Taxes.Dto
{
    public class PagedTaxResultRequestDto: PagedResultRequestDto, IPagedAndSortedResultRequest
    {
        public string Filter { get; set; }
        public string Sorting { get; set; }
    }
}
