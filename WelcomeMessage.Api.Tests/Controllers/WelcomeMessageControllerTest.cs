using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WelcomeMessage.Api;
using WelcomeMessage.Api.Controllers;

namespace WelcomeMessage.Api.Tests.Controllers
{
    [TestClass]
    public class WelcomeMessageControllerTest
    {
        [TestMethod]
        public void Get()
        {
            
            WelcomeMessageController controller = new WelcomeMessageController();

            
            string result = controller.Get();

            
            Assert.IsNotNull(result);
            Assert.AreEqual("Hello World", result);
            
        }
    }
}
