using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Kaya.Controllers
{
    public abstract class KayaControllerBase: AbpController
    {
        protected KayaControllerBase()
        {
            LocalizationSourceName = KayaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
