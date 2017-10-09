using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMessage.Api.Contracts;
using WelcomeMessage.Api.MessageProviders;

namespace WelcomeMessage.Api.MessageProviderFactory
{
    public class WelcomeMessageProviderFactory
    {
        public IWelcomeMessageProvider GetWelcomeMessageProvider()
        {
            var messageSource = Initializer.GetWelcomeMessageProviderSource();

            switch (messageSource)
            {
                case WelcomeMessageProviderSource.Sql:
                    return new SqlMessageProvider();

                default:
                    return new ConfiguredMessageProvider();
            }
        }

    }
}