using Microsoft.AspNetCore.Components;

namespace BlazorApp.Shared
{
    public partial class AdminLayout : LayoutComponentBase
    {
        // 可以在这里添加布局相关的逻辑
        [Inject]
        protected NavigationManager Navigation { get; set; }

        [Parameter]
        public string CurrentPageTitle { get; set; } = "管理后台";

        protected bool IsCurrentPage(string url)
        {
            var currentUrl = Navigation.Uri.Replace(Navigation.BaseUri, "/").TrimEnd('/');
            var targetUrl = url.TrimEnd('/');
            return currentUrl == targetUrl || currentUrl.StartsWith(targetUrl + "/");
        }

        protected string GetNavLinkClass(string url)
        {
            return IsCurrentPage(url) ? "nav-link active" : "nav-link";
        }

        // 可以在这里添加更多布局相关的共享方法和属性
        protected virtual void OnPageChanged(string newPage)
        {
            // 子类可以重写这个方法
        }
    }

}
