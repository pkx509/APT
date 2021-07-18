using Microsoft.AspNetCore.Components;

namespace GFCA.WebUI.Components.AdminLte
{
    public class BaseClasses : ComponentBase
    {
        [Parameter]
        public object Classes
        {
            get
            {
                return classes;
            }
            set
            {
                classes = value.ToString();
            }
        }

        public string classes { get; set; } = "";
    }
}
