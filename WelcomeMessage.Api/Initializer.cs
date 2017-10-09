using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using WelcomeMessage.Api.Contracts;

namespace WelcomeMessage.Api
{
    public class Initializer
    {
        private const string MessageSource = "MessageSource";
        private static WelcomeMessageProviderSource _Source;
        

        static Initializer()
        {
            InitalizeMessageSource();
        }

        private static void InitalizeMessageSource()
        {
            var source = ConfigurationManager.AppSettings[MessageSource];
            if (string.IsNullOrEmpty(source))
            {
                _Source = WelcomeMessageProviderSource.Configuration;
                return;
            }

            if (!Enum.TryParse(source, out _Source))
                _Source = WelcomeMessageProviderSource.Configuration;
        }

        internal static WelcomeMessageProviderSource GetWelcomeMessageProviderSource()
        {
            return _Source;
        }




    }
}