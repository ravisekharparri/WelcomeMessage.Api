using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WelcomeMessage.Api.MessageProviderFactory;

namespace WelcomeMessage.Api.Controllers
{
    public class WelcomeMessageController : ApiController
    {

        public string Get()
        {
            var messageProvider = new WelcomeMessageProviderFactory().GetWelcomeMessageProvider();
            return messageProvider.GetWelcomeMessage();
        }

        
    }
}