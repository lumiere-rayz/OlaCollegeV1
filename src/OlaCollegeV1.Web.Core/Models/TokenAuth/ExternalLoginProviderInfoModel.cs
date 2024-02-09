using Abp.AutoMapper;
using OlaCollegeV1.Authentication.External;

namespace OlaCollegeV1.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
