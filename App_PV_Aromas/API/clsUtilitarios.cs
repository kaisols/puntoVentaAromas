using App_PV_Aromas.Models;
using System;
using System.Text;
using System.Security.Cryptography; 
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Http;
using App_PV_Aromas.Helpers;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace App_PV_Aromas.API
{
    public static class clsUtilitarios
    { 

        public static JsonSerializerSettings Json_Settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

        public static Usuario miUsuarioLogueado { get; set; }



        #region SERIALIZAR OBJETOS
        public static string hacerJSON(Object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }
        #endregion 

        #region ENCRIPTAR CONTRASEÑA
        public static string encodePassword(string password)
        {
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(password);

            using (var sha1 = new SHA256Managed())
            {
                byte[] hash = sha1.ComputeHash(inputBytes);
                string result = Convert.ToBase64String(hash);

                return result;
            }
        }
        #endregion

        #region ValidacionString
        public static string validacionString(string validacion)
        {
            try
            {
                ///El primer argumento es el texto a validar
                ///El segundo es las concordancias por ejemplo 
                ///\w permite solo palabras
                ///\s permite espacios en blanco
                ///\.@- permite puntos arroba y guin medio 
                ///
                return Regex.Replace(validacion, @"[^\w\s\.@-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5)).Trim().ToUpper();
            }
            catch (RegexMatchTimeoutException ex)
            {
                //clsLogs log = new clsLogs(ex.StackTrace, ex.Message, "Login", "LimpiarEntrada",
                //    App_PV_AromasDeployment.CurrentDeployment.CurrentVersion.ToString());
                return String.Empty;
            }
        }
        #endregion

        #region ValidacionInt
        public static string validacionInt(string validacion)
        {
            try
            {
                ///El primer argumento es el texto a validar
                ///El segundo es las concordancias por ejemplo 
                ///\w permite solo palabras
                ///\s permite espacios en blanco
                ///\.@- permite puntos arroba y guin medio 
                ///
                return Regex.Replace(validacion, @"[^0-9:,]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5)).Trim();
            }
            catch (RegexMatchTimeoutException ex)
            {
                //clsLogs log = new clsLogs(ex.StackTrace, ex.Message, "Login", "LimpiarEntrada",
                //    App_PV_AromasDeployment.CurrentDeployment.CurrentVersion.ToString());
                return String.Empty;
            }
        }
        #endregion

        #region CONSULTAR PERSONA ANTE EL API
        public async static Task<UsuarioApi> ConsultarUsuarioApiAsync(String cedula)
        {
            string url = $@"https://apis.gometa.org/cedulas/{cedula}&key=Ln0BdUhrBpHpfRs";

            try
            {
                //await clsUtilitarios.popUpOn();

                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(url);

                String result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    UsuarioResult resultado = Newtonsoft.Json.JsonConvert.DeserializeObject<UsuarioResult>(result, clsUtilitarios.Json_Settings);

                    if (resultado != null && resultado.results.FirstOrDefault() != null)
                    {
                        UsuarioApi user = resultado.results.FirstOrDefault();
                        return user;
                    }
                    else
                    {
                        return null;
                    }

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }


        }
        #endregion      


        public static Usuario getUsuarioToSave()
        {
            return new Usuario
            {
                id = clsUtilitarios.miUsuarioLogueado.id,
                nombre = clsUtilitarios.miUsuarioLogueado.nombre,
                apellidos = clsUtilitarios.miUsuarioLogueado.apellidos,
                cedula = clsUtilitarios.miUsuarioLogueado.cedula
            };
        }

        //public static int getFundacionToSave()
        //{
        //    return clsUtilitarios.miUsuarioLogueado.miFundacion.id;
        //}




        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }


        public static string GetUID_Str()
        {
            var UID = new Guid();
            return UID.ToString();
        }


    } 
}
