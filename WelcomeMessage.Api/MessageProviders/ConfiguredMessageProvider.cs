using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using WelcomeMessage.Api.Contracts;

namespace WelcomeMessage.Api.MessageProviders
{
    public class ConfiguredMessageProvider : IWelcomeMessageProvider
    {
        const string WelcomeMessage = "WelcomeMessage";
        const string DefaultWelcomeMessage = "Hello World";

        public string GetWelcomeMessage()
        {
            try
            {
                return ConfigurationManager.AppSettings[WelcomeMessage];
            }
            catch
            {
                return DefaultWelcomeMessage;
            }
            

        }
    }
}