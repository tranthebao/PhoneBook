using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace HS.Farm.Web.Views
{
    public abstract class FarmRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FarmRazorPage()
        {
            LocalizationSourceName = FarmConsts.LocalizationSourceName;
        }
    }
}
