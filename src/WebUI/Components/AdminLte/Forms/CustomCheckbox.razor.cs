using Microsoft.AspNetCore.Components;

namespace GFCA.WebUI.Components.AdminLte
{
    public partial class CustomCheckbox
    {
        [Parameter]
        public CustomCheckboxState Value { get; set; }

        [Parameter]
        public EventCallback<CustomCheckboxState>ValueChanged { get; set; }

        [Parameter]
        public EventCallback<CustomCheckboxState> OnChange { get; set; }

        private void DoChange(ChangeEventArgs e)
        {
            Value.IsChecked = (bool?)e.Value;
            ValueChanged.InvokeAsync(Value);
            if (OnChange.HasDelegate)
              OnChange.InvokeAsync(Value);
        }
    }
}
