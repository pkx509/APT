using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace GFCA.WebUI.Components.AdminLte
{
    public partial class NavBarLeft
    {

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        protected ElementReference pushButton { get; set; }

        protected int x = 0;

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                // initiates the data-widget from blazor, preserves the virtual dom.
                JS.InvokeVoidAsync("click", pushButton);
            }
            // Hack for WASM.
            x++;
            if (x == 1) StateHasChanged();
            if (x == 2)
                x = 0;
        }

    }
}
