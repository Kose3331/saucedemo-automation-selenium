using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Pages
{
    public class CheckoutPage : BasePage
    {
        private readonly By firstNameField = By.Id("first-name");

        private readonly By lastNameField = By.Id("last-name");

        private readonly By zipCodeField = By.Id("postal-code");

        private readonly By continueButton = By.Id("continue");

        private readonly By finishButton = By.CssSelector("#finish");

        private readonly By completeHeader = By.CssSelector(".complete-header");
        public CheckoutPage(IWebDriver driver) : base(driver)
        {

        }

        public void EnterFirstName(string firstName)
        {
            Type(firstNameField, firstName);
        }

        public void EnterLastName(string lastName)
        {
            Type(lastNameField, lastName);
        }

        public void EnterZipCode(string zipCode)
        {
            Type(zipCodeField, zipCode);
        }

        public void ClickContinue()
        
        {
            Click(continueButton);
        }

        public void ClickFinish()
        {
            Click(finishButton);
        }

        public bool IsPageLoaded()
        {
            return driver.Url.Contains("checkout-step-one.html") ||
            driver.Url.Contains("checkout-step-two.html");
        }

        public bool IsCheckoutComplete()
        {
            return GetText(completeHeader) == "Thank you for your order!";
        }

    }
}
