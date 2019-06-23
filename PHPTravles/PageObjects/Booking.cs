using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravles.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selector = PHPTravles.TestAutomation.PageObjectModels.Locators.Booking;
#pragma warning disable 649,612,618

namespace PHPTravles.PageObjects
{
    public class Booking
    {
        public Booking() => PageFactory.InitElements(PropertiesCollection.driver, this);


        public void waituntilSignIn() => PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(Selector.Signin)));

        [FindsBy(How = How.Id, Using = Selector.Signin)]
        private IWebElement SignIn;
        public void ClickonSignIn() => SignIn.Click();

        [FindsBy(How = How.Id, Using = Selector.username)]
        private IWebElement username;
        public void EnterUsername(string Username)
        {
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(Selector.username)));
            username.SendKeys(Username);
        }

        [FindsBy(How = How.Id, Using = Selector.password)]
        private IWebElement password;
        public void EnterPassword(string Password) => password.SendKeys(Password);

        [FindsBy(How = How.Id, Using = Selector.passengername)]
        private IWebElement passengername;
        public void EnterPassengerName(string PassengerName) => passengername.SendKeys(PassengerName);

        [FindsBy(How = How.Id, Using = Selector.passengerage)]
        private IWebElement passengerage;
        public void EnterPassengerAge(string PassengerAge) => passengerage.SendKeys(PassengerAge);

        [FindsBy(How = How.Id, Using = Selector.passportnumber)]
        private IWebElement passportnumber;
        public void EnterPassportnumber(string PassportNumber) => passportnumber.SendKeys(PassportNumber);

        [FindsBy(How = How.Name, Using = Selector.confirmbooking)]
        private IWebElement confirmbooking;
        public void ClickConfirmBooking()
        {
            PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(Selector.confirmbooking)));
            confirmbooking.SendKeys("");
            confirmbooking.Click();
        }
    }
}
