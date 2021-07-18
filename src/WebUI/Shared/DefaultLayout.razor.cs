using System;
using System.Threading.Tasks;
using GFCA.WebUI.Components.AdminLte;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace GFCA.WebUI.Shared
{
    public partial class DefaultLayout
    {
        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public IJSRuntime JS { get; set; }
        [Inject] public NavBarLeftInjectableMenu navBarLeftInjectableMenu { get; set; }
        [Inject] public ILayoutManager layoutManager { get; set; }

        private DateTime dt = DateTime.Now;

        protected override void OnParametersSet()
        {
            //layoutManager.IsFooterFixed = true;
            //layoutManager.IsNavBarFixed = true;
            //layoutManager.IsSideBarFixed = true;
            // content = null; for refreshing custom menu injectables per page.
            // no override; reset default to show parent menu content items.
            navBarLeftInjectableMenu.SetContent(null, false);
            //StateHasChanged();
        }

        private void SeeAllMessages(Tuple<IDropdownFooter, MouseEventArgs> args)
        {
            //NavigationManager.NavigateTo("messages/see-all-messages");
        }
        private void SeeAllNotifications(Tuple<IDropdownFooter, MouseEventArgs> args)
        {
            //NavigationManager.NavigateTo("messages/see-all-notifications");
        }

        protected override void OnAfterRender(bool firstRender)
        {
            layoutManager.IsFooterFixed = true;
            layoutManager.IsNavBarFixed = true;
            layoutManager.IsSideBarFixed = true;
            base.OnAfterRender(firstRender);
        }

    }
}
