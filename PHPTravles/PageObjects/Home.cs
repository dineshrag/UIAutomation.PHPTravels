using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravles.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selector = PHPTravles.TestAutomation.PageObjectModels.Locators.HomePage;
#pragma warning disable 649,612,618

namespace PHPTravles.PageObjects
{
    class Home
    {
        public Home() => PageFactory.InitElements(PropertiesCollection.driver, this);

        public void NavigatetoURL() => PropertiesCollection.driver
            .Navigate()
            .GoToUrl(ConfigurationManager.AppSettings["baseurl"].ToString());

        public void Maximizewindow() => PropertiesCollection.driver
            .Manage()
            .Window
            .Maximize();

        public void VerifyHotelsonHomepage() => PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Selector.hotels)));

        [FindsBy(How = How.XPath, Using = Selector.flights)]
        private IWebElement flights;
        public void Clickonflights() => flights.Click();

        [FindsBy(How = How.XPath, Using = Selector.roundtrip)]
        private IWebElement roundtrip;
        public void Clickonroundtrip()
        {
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(Selector.roundtrip)));
            roundtrip.Click();
        }

        [FindsBy(How = How.Name, Using = Selector.cabinclass)]
        private IWebElement cabinclass;
        public void Selectcabinclass(string cabintype) => cabinclass.SendKeys(cabintype);

        [FindsBy(How = How.XPath, Using = Selector.enterfromcityorairport)]
        private IWebElement enterfromcityorairport;
        public void ClickFromcityairport() => enterfromcityorairport.Click();

        [FindsBy(How = How.XPath, Using = Selector.fromcityorairport)]
        private IWebElement fromcityorairport;
        public void Fromcityairport(string cityairport)
        {
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(Selector.fromcityorairport)));
            fromcityorairport.SendKeys(cityairport);
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(Selector.cityairport)));
            IWebElement ddcityairport = PropertiesCollection.driver.FindElement(By.XPath(Selector.cityairport));
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(ddcityairport, cityairport));
        }

        [FindsBy(How = How.XPath, Using = Selector.cityairport)]
        private IWebElement cityairport;
        public void Selectcityairport() => cityairport.Click();

        [FindsBy(How = How.XPath, Using = Selector.entertocityorairport)]
        private IWebElement entertocityorairport;
        public void ClickTocityairport() => entertocityorairport.Click();

        [FindsBy(How = How.XPath, Using = Selector.tocityorairport)]
        private IWebElement tocityorairport;
        public void Tocityairport(string cityorairport)
        {
            tocityorairport.SendKeys(cityorairport);
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(Selector.cityairport)));
            IWebElement ddcityairport = PropertiesCollection.driver.FindElement(By.XPath(Selector.cityairport));
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(ddcityairport, cityorairport));
        }

        [FindsBy(How = How.Name, Using = Selector.depature)]
        private IWebElement depature;
        public void Departure(string depaturedate) => depature.SendKeys(depaturedate);

        [FindsBy(How = How.Name, Using = Selector.arrival)]
        private IWebElement arrival;
        public void Arrival(string arrivaldate) => arrival.SendKeys(arrivaldate);

        [FindsBy(How = How.Name, Using = Selector.arrival)]
        private IWebElement totalnumberofpassengers;
        public void Clickonpassengers()
        {
            totalnumberofpassengers.Click();
            IWebElement passengers = PropertiesCollection.driver.FindElement(By.Name(Selector.totalnumberofpassengers));
            new Actions(PropertiesCollection.driver).DoubleClick(passengers).Build().Perform();
        }

        public void VerifyPassengers() => PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(Selector.adultpassengers)));

        [FindsBy(How = How.Name, Using = Selector.adultpassengers)]
        private IWebElement adultpassengerscount;
        public void Enterpassengers(string AdultPassengerscount) => adultpassengerscount.SendKeys(AdultPassengerscount);

        [FindsBy(How = How.Id, Using = Selector.done)]
        private IWebElement done;
        public void Done() => done.Click();

        [FindsBy(How = How.XPath, Using = Selector.search)]
        private IWebElement search;
        public void Search()
        {
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(Selector.search)));
            search.Click();
        }

    }
}
