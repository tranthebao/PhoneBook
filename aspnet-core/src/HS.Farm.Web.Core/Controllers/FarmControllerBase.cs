using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HS.Farm.Controllers
{
    public abstract class FarmControllerBase: AbpController
    {
        protected FarmControllerBase()
        {
            LocalizationSourceName = FarmConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
