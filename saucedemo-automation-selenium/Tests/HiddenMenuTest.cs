using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Tests
{
    public class HiddenMenuTest : BaseTest
    {

        [SetUp]
        public void SetUp()
        {
            LogIn("standard_user", "secret_sauce");
        }

        [Test]
        public void TestOpenMenu()
        {
            hiddenMenuPage.ClickMenuButton();
            Assert.That(hiddenMenuPage.IsMenuOpen, Is.True);    
        }

        [Test]
        public void TestLogout()
        {
            hiddenMenuPage.ClickMenuButton();
            hiddenMenuPage.ClickLogoutBtn();

            Assert.True(driver.Url.Equals("https://www.saucedemo.com/"));
        }
    }
}
