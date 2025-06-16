using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Tests
{
    public class InventoryTest : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            LogIn("standard_user", "secret_sauce");
        }
        [Test]
        public void TestInventoryDisplay()
        {

            Assert.That(inventoryPage.IsInventoryDisplayed(), Is.True);
        }

        [Test]
        public void TestAddToCartByIndex()
        {
            inventoryPage.addToCartByIndex(1);
            inventoryPage.ClickCartlink();

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);   
        }

        [Test]

        public void TestAddToCartByName()
        {
            inventoryPage.addToCartByName("Sauce Labs Backpack");
            inventoryPage.ClickCartlink();

            Assert.That(cartPage.IsCartItemDisplayed(), Is.True);
        }

        [Test]
        public void TestPageTitle()
        {
            Assert.That(inventoryPage.IsInventoryPageLoaded(), Is.True);    
        }
    }
}
