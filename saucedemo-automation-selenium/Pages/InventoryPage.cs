using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo_automation_selenium.Pages
{
    
    public class InventoryPage : BasePage
    {
        private readonly By cartLink = By.CssSelector(".shopping_cart_link");
        private readonly By productsPageTitle = By.ClassName("title");
        private readonly By inventoryItems = By.CssSelector(".inventory_item");
        public InventoryPage(IWebDriver driver) : base(driver)
        {
            
        }

        public void addToCartByIndex(int itemIndex)
        {
            var itemByIndexButton = By.XPath($"//div[@class='inventory_list']//div[@class='inventory_item'][{itemIndex}]//button");
            Click(itemByIndexButton);
        }
        public void addToCartByName(string productName)
        {
            var itemByName = By.XPath($"//div[text() = '{productName}']/ancestor::div[@class='inventory_item_description']//button");
            Click(itemByName);
        }

        public void ClickCartlink()
        {
            Click(cartLink);
        }

        public bool IsInventoryDisplayed()
        {
            return FindElements(inventoryItems).Any();  
        }

        public bool IsInventoryPageLoaded()
        {
            return GetText(productsPageTitle) == "Products" && driver.Url.Contains("inventory.html");
        }
    }
}
