using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace App_PV_Aromas.Helpers
{
    public interface IHelperService
    {
        void TokenVencido();
    }

    public partial class HelperService : IHelperService
    {
        private IAuthenticationService authenticationService1;
        public HelperService(IAuthenticationService Auth)
        {
            authenticationService1 = Auth;
        }

        public async void TokenVencido()
        {
            await authenticationService1.Logout(); 
        }
    }
}
