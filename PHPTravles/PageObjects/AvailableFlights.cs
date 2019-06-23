using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravles.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selector = PHPTravles.TestAutomation.PageObjectModels.Locators.AvailableFlights;
#pragma warning disable 649,612,618

namespace PHPTravles.PageObjects
{
    public class AvailableFlights
    {
        public AvailableFlights() => PageFactory.InitElements(PropertiesCollection.driver, this);

        public void waituntilAvailableFlights() => PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Selector.availablefirstflight)));

        [FindsBy(How = How.XPath, Using = Selector.availablefirstflight)]
        private IWebElement Availablefirstflight;
        public void Clickonavailableflight() => Availablefirstflight.Click();
    }
}
