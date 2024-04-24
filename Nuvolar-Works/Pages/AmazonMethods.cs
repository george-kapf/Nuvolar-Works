using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amazonweb.Pages
{
    public class AmazonMethods
    {
        private IWebDriver driver;
        public string text;

        // Locator

        By searchBox = By.XPath("//input[@id='twotabsearchtextbox']");
        By searchButton = By.XPath("//input[@id='nav-search-submit-button']");
        By firstItem = By.XPath("(//span[@class='a-size-base-plus a-color-base a-text-normal'])[1]");
        By quantityDropdown = By.XPath("//span[normalize-space()='Quantity:']");
        By quantity = By.XPath("//a[@id='quantity_1']");
        By addCart = By.XPath("//input[@id='add-to-cart-button']");
        By gotoCart = By.XPath("//a[@href='/cart?ref_=sw_gtc']");
        By totalDetails = By.XPath("//div[@class='a-row a-spacing-mini sc-subtotal sc-subtotal-activecart sc-java-remote-feature']");
        By firstWomenItem = By.XPath("(//span[@class='a-size-base-plus a-color-base a-text-normal'])[1]");
        By quantityRemoveDropdown = By.XPath("(//span[@class='a-button-text a-declarative'])[2]");
        By quantityOneWomen = By.XPath("(//span[normalize-space()='Quantity:1'])[1]");
        By itemDetails = By.XPath("//div[@data-item-index='1'][@class='a-row ewc-item']");
        By finalTotal = By.XPath("//div[@class='a-row a-spacing-mini sc-subtotal sc-subtotal-activecart sc-java-remote-feature']");




        public 
            AmazonMethods(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SearchBox()
        {
            return driver.FindElement(searchBox);
        }
        public IWebElement SearchButton()
        {
          return (IWebElement)driver.FindElement(searchButton);
        } 
        public IWebElement FirstItem()
        {
          return (IWebElement)driver.FindElement(firstItem);
        }
        public IWebElement QuantityDropdown()
        {
          return (IWebElement)driver.FindElement(quantityDropdown);
        }
        public IWebElement Quantity()
        {
          return (IWebElement)driver.FindElement(quantity);
        }
        public IWebElement AddCart()
        {
          return (IWebElement)driver.FindElement(addCart);
        } 
        public IWebElement GotoCart()
        {
          return (IWebElement)driver.FindElement(gotoCart);
        }
        public IWebElement TotalDetails()
        {
          text = driver.FindElement(totalDetails).Text;
          return (IWebElement)driver.FindElement(totalDetails);
        }
        public IWebElement FirstWomenItem()
        {
            return (IWebElement)driver.FindElement(firstWomenItem);
        }
        public IWebElement ItemDetails()
        {
            text = driver.FindElement(itemDetails).Text;
            return (IWebElement)driver.FindElement(itemDetails);
        }
        public IWebElement QuantityOneWomen()
        {
            return (IWebElement)driver.FindElement(quantityOneWomen);
        }
        public IWebElement QuantityRemoveDropdown()
        {
            return (IWebElement)driver.FindElement(quantityRemoveDropdown);
        }
        public IWebElement FinalTotal()
        {
            text = driver.FindElement(finalTotal).Text;
            return (IWebElement)driver.FindElement(finalTotal);
        }

    }
}
