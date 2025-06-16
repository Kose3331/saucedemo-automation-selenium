using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V125.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Pages
{
    public class LoginPage : BasePage
    {
        private readonly By userNameField = By.XPath("//input[@id='user-name']");

        private readonly By passwordField = By.XPath("//input[@id='password']");

        private readonly By loginButton = By.XPath("//input[@type='submit']");

        private readonly By errorMessage = By.XPath("//div[@class='error-message-container error']");
        public LoginPage(IWebDriver driver) : base(driver) 
        {
            
        }
        
        public void InputUserName(string username)
        {
            Type(userNameField, username);
        }

        public void InputPassword(string password)
        {
            Type(passwordField, password);
        }

        public void ClickLoginButton()
        {
            Click(loginButton);
        }

        public string GetErrorMessage()
        {
            return  GetText(errorMessage);
        }
    }
}
