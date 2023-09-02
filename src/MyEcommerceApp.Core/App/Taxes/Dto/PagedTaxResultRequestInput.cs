using Abp.Application.Services.Dto;


namespace MyEcommerceApp.App.Taxes.Dto
{
    public class PagedTaxResultRequestInput: PagedResultRequestDto, IPagedAndSortedResultRequest
    {
        public string Filter { get; set; }
        public string Sorting { get; set; }       
    }
}
