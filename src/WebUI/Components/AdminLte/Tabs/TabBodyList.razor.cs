using Microsoft.AspNetCore.Components;

namespace GFCA.WebUI.Components.AdminLte
{
    partial class TabBodyList
    {
        [Parameter]
        public string Identifier { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
