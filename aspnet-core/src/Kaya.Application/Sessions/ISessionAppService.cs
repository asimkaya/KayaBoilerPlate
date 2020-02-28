using System.Threading.Tasks;
using Abp.Application.Services;
using Kaya.Sessions.Dto;

namespace Kaya.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
