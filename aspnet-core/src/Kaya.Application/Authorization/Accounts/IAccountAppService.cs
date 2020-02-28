using System.Threading.Tasks;
using Abp.Application.Services;
using Kaya.Authorization.Accounts.Dto;

namespace Kaya.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
