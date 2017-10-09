using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelcomeMessage.Api.Contracts
{
    public interface IWelcomeMessageProvider
    {
        string GetWelcomeMessage();
    }
}