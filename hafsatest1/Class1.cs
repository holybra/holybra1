
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.IE;
using System;

namespace hafsatest1
{
    [TestFixture]
    public class Classe2
    {
        static String nodeurl;
        static IWebDriver browser;
        [Test]
        public void gotoyoutube()
        {

            nodeurl = "http://192.168.1.2:33194/wd/hub";
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.Chrome();
            capabilities.SetCapability(CapabilityType.BrowserName, "chrome");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            var commandTimeout = TimeSpan.FromMinutes(5);
            browser = new RemoteWebDriver(new Uri(nodeurl), capabilities, commandTimeout);
            browser.Manage().Window.Maximize();

            browser.Navigate().GoToUrl("https://www.youtube.com");

            browser.Close();
        }
      
        [Test]
        public void gotogoogle()
        {

            nodeurl = "http://192.168.1.2:41704/wd/hub";
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.Firefox();
            capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            var commandTimeout = TimeSpan.FromMinutes(5);
            browser = new RemoteWebDriver(new Uri(nodeurl), capabilities, commandTimeout);
            browser.Manage().Window.Maximize();

            browser.Navigate().GoToUrl("https://www.google.com");

            browser.Close();
        }
        [Test]
        public void gotofacebook()
        {

            nodeurl = "http://192.168.1.2:41704/wd/hub";
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities = DesiredCapabilities.Firefox();
            capabilities.SetCapability(CapabilityType.BrowserName, "firefox");
            capabilities.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            var commandTimeout = TimeSpan.FromMinutes(5);
            browser = new RemoteWebDriver(new Uri(nodeurl), capabilities, commandTimeout);
            browser.Manage().Window.Maximize();

            browser.Navigate().GoToUrl("https://www.facebook.com");

            browser.Close();
        }
        
    }


}