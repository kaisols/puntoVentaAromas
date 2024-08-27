using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using App_PV_Aromas;
using App_PV_Aromas.API; 
using CurrieTechnologies.Razor.SweetAlert2;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddSingleton<IServicioApi, clsServicio>();
builder.Services.AddSingleton<ILocalStorageService, LocalStorageService>();
builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazorBootstrap();


builder.Services.AddSweetAlert2();

var host = builder.Build();

var authenticationService = host.Services.GetRequiredService<IAuthenticationService>();
await authenticationService.Initialize();

await host.RunAsync();
