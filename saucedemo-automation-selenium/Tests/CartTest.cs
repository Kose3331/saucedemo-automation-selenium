using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Tests
{
    public class CartTest : BaseTest
    {
        [SetUp] 
        public void SetUp()
        {
            LogIn("standard_user", "secret_sauce");

            inventoryPage.addToCartByIndex(1);
            inventoryPage.ClickCartlink();
        }

        [Test]
        public void TestCartItemDisplayed()
        {
            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }
        [Test]
        public void TestClickCheckout()
        {
            cartPage.ClickCheckout();
            Assert.That(checkoutPage.IsPageLoaded(), Is.True);  
        }
    }
}
