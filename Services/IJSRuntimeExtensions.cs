using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uttarakhand_project_front.Services
{
    public static class IJSRuntimeExtensions
    {
        public static ValueTask ShowAlert(this IJSRuntime jS, string message)
        {
            return jS.InvokeVoidAsync("Swal.fire", message);
        }

        public static ValueTask ShowAlert(this IJSRuntime js, string title, string message, SweetAlertMessageType sweetAlertMessageType)
        {
            return js.InvokeVoidAsync("Swal.fire", title, message, sweetAlertMessageType.ToString());
        }

        public static ValueTask ShowModel(this IJSRuntime jS, string ModelId)
        {
            return jS.InvokeVoidAsync("global.openModal", ModelId);
        }

        public static ValueTask CloseModel(this IJSRuntime jS, string ModelId)
        {
            return jS.InvokeVoidAsync("global.closeModal", ModelId);
        }

        public static ValueTask ShowNavMenu(this IJSRuntime jS)
        {
            return jS.InvokeVoidAsync("global.showNavMenu");
        }

        public static ValueTask ShowCalender(this IJSRuntime jS, string ModelId)
        {
            return jS.InvokeVoidAsync("global.showCalender", ModelId);
        }

        public static ValueTask ShowTimer(this IJSRuntime jS, int duration, string timerShowTag, bool flag)
        {
            return jS.InvokeVoidAsync("global.showTimer", duration, timerShowTag, flag);
        }
    }

    public enum SweetAlertMessageType
    {
        question, warning, error, success, info
    }
}
