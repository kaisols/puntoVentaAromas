using App_PV_Aromas.Models;
using System.Text.Json;
using System.Text;
using Microsoft.AspNetCore.Components;
using App_PV_Aromas.Helpers;
using System.Net.Http.Json;

namespace App_PV_Aromas.API
{
    public interface IServicioApi
    {
        Task<Respuesta> PostAsync<T>(string Controller, string Metodo, T enviar, bool Token);
    }

    public class clsServicio : IServicioApi
    {
        private IAuthenticationService AuthenticationService;

        private JsonSerializerOptions OpcionesPorDefectoJSON =>
           new JsonSerializerOptions()
           {
               PropertyNameCaseInsensitive = true,
               DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
           };


        public clsServicio(IAuthenticationService authenticationService)
        {
            AuthenticationService = authenticationService;
        }

#if DEBUG
        private string BASEURL = "https://localhost:7219/api/";
#endif

#if !DEBUG
        private string BASEURL = "http://186.15.20.88:8087/apiTickets/api/";
#endif


        public async Task<Respuesta> PostAsync<T>(string Controller, string Metodo, T enviar, bool Token)
        {
            try
            { 

                using (HttpClient client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(10);

                    string url = $"{BASEURL}{Controller}/{Metodo}";

                    if (Token)
                    {
                        string Token_Str = clsUtilitarios.miUsuarioLogueado.Token;
                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token_Str}");
                    }

                    string valorEnviar = JsonSerializer.Serialize(enviar, OpcionesPorDefectoJSON);

                    Respuesta miRespuesta = new Respuesta { codigoError = 404, mensaje = "Error no controlado", resultado = false };

                    StringContent enviarContent = new StringContent(valorEnviar, Encoding.UTF8, "application/json");

                    HttpResponseMessage responseHttp = await client.PostAsync(url, enviarContent);
                   
                    if (responseHttp.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        miRespuesta.resultado = false;
                        miRespuesta.mensaje = "La sesión ha expirado!";
                        HelperService Helpers = new HelperService(AuthenticationService);
                        Helpers.TokenVencido();
                    }
                    else
                    {
                        miRespuesta = await responseHttp.Content.ReadFromJsonAsync<Respuesta>(); 
                    }
                    
                    return miRespuesta;
                }

            }
            catch (Exception ecx)
            {
                return new Respuesta { codigoError = -404, mensaje = "Intente de Nuevo, por favor.", objeto = null, resultado = false };
            }
        }
    }
}
