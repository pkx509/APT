﻿using Microsoft.AspNetCore.Components;

namespace GFCA.WebUI.Components.AdminLte
{
    partial class TabBodyItem
    {
        [CascadingParameter (Name = "ParentIdentifier")]
        public string ParentIdentifier { get; set; }

        [Parameter]
        public string Identifier { get; set; }
        [Parameter]
        public bool IsActive { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private string CompositeIdentifier => $"{ParentIdentifier}_{Identifier}";
    }
}
