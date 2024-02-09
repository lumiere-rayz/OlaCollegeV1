using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OlaCollegeV1.Controllers
{
    public abstract class OlaCollegeV1ControllerBase: AbpController
    {
        protected OlaCollegeV1ControllerBase()
        {
            LocalizationSourceName = OlaCollegeV1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
