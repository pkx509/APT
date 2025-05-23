﻿using System;
using Microsoft.AspNetCore.Components;

namespace GFCA.WebUI.Components.AdminLte
{
    public partial class InjectableChildContent
    {
        [Parameter]
        public RenderFragment content { get; set; }

        public bool OverrideParentContent { get; set; }

        public void SetContent(RenderFragment ctx, bool overrideParentContent = false)
        {
            if (ctx == null)
            {
                content = null;
            }
            else
            {
                content = (RenderFragment)ctx.Clone();
            }


            OverrideParentContent = overrideParentContent;

            //return null;
        }

        public RenderFragment GetContent()
        {
            return content;
        }
    }
}
