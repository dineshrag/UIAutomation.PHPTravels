using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PHPTravles.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selector = PHPTravles.TestAutomation.PageObjectModels.Locators.Invoice;
#pragma warning disable 649,612,618

namespace PHPTravles.PageObjects
{
    public class Invoice
    {
        public Invoice() => PageFactory.InitElements(PropertiesCollection.driver, this);

        public void waituntilInvoice() => PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Selector.invoive)));
    }
}
