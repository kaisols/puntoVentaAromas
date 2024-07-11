using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace App_PV_Aromas.Helpers
{
    public static class JavascriptUtils
    {
        public static ValueTask<object> openImageWindows(this IJSRuntime js, string Image)
        => js.InvokeAsync<object>(
          "openImageWindows",
          Image);


        public static ValueTask<object> DeleteCookies(this IJSRuntime js)
      => js.InvokeAsync<object>(
        "deleteAllCookies");
    }
}
