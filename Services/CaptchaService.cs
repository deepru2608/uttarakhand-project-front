using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using uttarakhand_project_front.Models;

namespace uttarakhand_project_front.Services
{
    public class CaptchaService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IOptions<ReCaptchaVerificationOptions> _reCaptchaVerificationOptions;

        public CaptchaService(IHttpClientFactory httpClientFactory,
            IOptions<ReCaptchaVerificationOptions> reCaptchaVerificationOptions)
        {
            this._httpClientFactory = httpClientFactory;
            this._reCaptchaVerificationOptions = reCaptchaVerificationOptions;
        }

        public async Task<string> GetCaptchaVerification(SampleApiArgs args)
        {
            string message = string.Empty;
            var url = "https://www.google.com/recaptcha/api/siteverify";
            var content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"secret", this._reCaptchaVerificationOptions.Value.Secret},
                {"response", args.ReCaptchaResponse}
            });

            var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            var verificationResponse = response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ReCaptchaVerificationResponse>(verificationResponse.Result);
            if (result.Success)
            {
                message = "success";
                return message;
            }
            message = string.Join(", ", result.ErrorCodes.Select(err => err.Replace('-', ' ')));
            return message;
        }
    }
}
