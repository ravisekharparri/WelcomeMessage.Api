using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMessage.Api.Contracts;

namespace WelcomeMessage.Api.MessageProviders
{
    public class SqlMessageProvider : IWelcomeMessageProvider
    {

        public string GetWelcomeMessage()
        {
            throw new NotImplementedException();
        }
    }
}