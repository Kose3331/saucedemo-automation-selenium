using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Tests
{
    public class LoginTestcs : BaseTest
    {
        [Test]

        public void LoginWithValidCredentials()
        {
            LogIn("standard_user", "secret_sauce");

            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True);   
        }

        [Test]

        public void LoginWithInvalidCredentials()
        {
            LogIn("Kose", "secret_sauce");

            Assert.That(loginPage.GetErrorMessage, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test]

        public void LoginWithLockedOutUser()
        {
            LogIn("locked_out_user", "secret_sauce");


            Assert.That(loginPage.GetErrorMessage, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }
    }
}
