using System;
using Microsoft.AspNetCore.Components;
namespace GFCA.WebUI.Services
{
    public class HelperService
    {
        private NavigationManager _navMgr;
        public HelperService(NavigationManager navigationManager)
        {
            _navMgr = navigationManager;
        }

        public void ChangePage(string virtualPath)
        {
            _navMgr.NavigateTo(virtualPath);
        }
    }
}
