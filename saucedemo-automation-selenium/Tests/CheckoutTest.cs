using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Tests
{
    public class CheckoutTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            LogIn("standard_user", "secret_sauce");

            inventoryPage.addToCartByIndex(1);
            inventoryPage.ClickCartlink();
            cartPage.ClickCheckout();


        }
        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.That(checkoutPage.IsPageLoaded, Is.True);
        }

        [Test]
        public void TestCheckoutPageUnloaded()
        {
            checkoutPage.EnterFirstName("kose");
            checkoutPage.EnterLastName("bose");
            checkoutPage.EnterZipCode("2000");
            checkoutPage.ClickContinue();

            Assert.That(checkoutPage.IsPageLoaded, Is.True);

        }

        [Test]
        public void TestFinishOrder()
        {
            checkoutPage.EnterFirstName("kose");
            checkoutPage.EnterLastName("bose");
            checkoutPage.EnterZipCode("2000");
            checkoutPage.ClickContinue();
            checkoutPage.ClickFinish();

            Assert.True(checkoutPage.IsCheckoutComplete());  
        }
    }
}
