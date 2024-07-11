using Microsoft.AspNetCore.Components;
using App_PV_Aromas.Models;

namespace App_PV_Aromas
{
    public interface IAuthenticationService
    {
        Usuario User { get; }
        Task Initialize();
        Task Login(Usuario miUsuario);
        Task<Usuario> GetUser();
        Task UpdateUser(Usuario miUsuario);
        Task Logout();
    }

    public class AuthenticationService : IAuthenticationService
    {
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;

        public Usuario User { get; private set; }

        public AuthenticationService(NavigationManager navigationManager, ILocalStorageService localStorageService)
        {
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            User = await _localStorageService.GetItem<Usuario>("user");

        }

        public async Task<Usuario> GetUser()
        {
            return await _localStorageService.GetItem<Usuario>("user");
        }

        public async Task Login(Usuario miUsuario)
        {
            this.User = miUsuario;
            await _localStorageService.SetItem("user", miUsuario);
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem("user");
            _navigationManager.NavigateTo("login");
        }

        public async Task UpdateUser(Usuario miUsuario)
        { 
            await _localStorageService.RemoveItem("user");
            this.User = miUsuario;
            await _localStorageService.SetItem("user", miUsuario);
        }


    }
}
