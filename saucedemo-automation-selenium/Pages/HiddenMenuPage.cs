using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Pages
{
    public class HiddenMenuPage : BasePage
    {
        private readonly By containerMenu = By.ClassName("bm-menu");

        private readonly By hiddenMenuBtn = By.Id("react-burger-menu-btn");

        private readonly By logout = By.Id("logout_sidebar_link");
        public HiddenMenuPage(IWebDriver driver):base(driver)
        {
            
        }

        public void ClickMenuButton()
        {
            Click(hiddenMenuBtn);
        }

        public void ClickLogoutBtn()
        {
            Click(logout);
        }

        public bool IsMenuOpen()
        {
            return FindElement(logout).Displayed;
        }
    }
}
