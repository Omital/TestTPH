using Abp.Web.Mvc.Views;

namespace TestTPH.Web.Views
{
    public abstract class TestTPHWebViewPageBase : TestTPHWebViewPageBase<dynamic>
    {

    }

    public abstract class TestTPHWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TestTPHWebViewPageBase()
        {
            LocalizationSourceName = TestTPHConsts.LocalizationSourceName;
        }
    }
}