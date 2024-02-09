using System.Threading.Tasks;
using Abp.Application.Services;
using OlaCollegeV1.Sessions.Dto;

namespace OlaCollegeV1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
