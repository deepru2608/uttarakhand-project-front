using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uttarakhand_project_front.Data;
using uttarakhand_project_front.ViewModels;
using uttarakhand_project_front.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using Syncfusion.Blazor.Inputs.Internal;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net;
using System.Net.Http;
using System.Collections.Specialized;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;


namespace uttarakhand_project_front.Services
{
    public class HelperService
    {
        public static SortedDictionary<string, string> SortNameValueCollection(NameValueCollection nvc)
        {
            SortedDictionary<string, string> sortedDict = new SortedDictionary<string, string>();
            foreach (String key in nvc.AllKeys)
                sortedDict.Add(key, nvc[key]);
            return sortedDict;
        }

        public static string GetAppConfig(string Key)
        {
            return GetAppConfig(Key, "");
        }

        public static string GetAppConfig(string Key, string defaultValue)
        {
            string appConfigValue = "";
            string AppValue = System.Configuration.ConfigurationManager.AppSettings[Key];
            if (string.IsNullOrEmpty(AppValue))
            {
                if (!string.IsNullOrEmpty(defaultValue))
                    appConfigValue = defaultValue;
                else
                    appConfigValue = "";
            }
            else
            {
                appConfigValue = AppValue;
            }
            return appConfigValue;
        }

    }
}
