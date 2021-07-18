using System;

namespace GFCA.WebUI.Components.AdminLte
{
    public class StyleAttribute : Attribute, IDescription
    {
        public string Description { get; set; }

        public StyleAttribute(string description)
        {
            Description = description;
        }
    }
}
