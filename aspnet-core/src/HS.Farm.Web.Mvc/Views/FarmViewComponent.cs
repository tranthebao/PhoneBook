using Abp.AspNetCore.Mvc.ViewComponents;

namespace HS.Farm.Web.Views
{
    public abstract class FarmViewComponent : AbpViewComponent
    {
        protected FarmViewComponent()
        {
            LocalizationSourceName = FarmConsts.LocalizationSourceName;
        }
    }
}
