using amazonweb.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace amazonweb.StepDefinitions
{
    [Binding]
    public class AmazonwebStep
    {
        private IWebDriver driver;
        public AmazonMethods amazonMethods;

        public AmazonwebStep( IWebDriver driver, AmazonMethods amazonMethods)
        {
            this.driver = driver;
            this.amazonMethods = amazonMethods;
        }

        [Given(@"go to amazon website")]
        public void GivenGoToAmazonWebsite()
        {
            driver.Url = "https://www.amazon.com/";
            //Thread.Sleep(1000);
            driver.Navigate().Refresh();
        }

        [When(@"click on the search input field and search ""([^""]*)""")]
        public void WhenClickOnTheSearchInputFieldAndSearch(string item)
        {
            amazonMethods.SearchBox().SendKeys(item);
           // Thread.Sleep(1000);
        }

        [When(@"Click on the search button")]
        public void WhenClickOnTheSearchButton()
        {
            amazonMethods.SearchButton().Click();
           // Thread.Sleep(1000);
        }

        [When(@"Add first hat to Cart with quantity two")]
        public void WhenAddFirstHatToCartWithQuantityTwo()
        {
     
            amazonMethods.FirstItem().Click();
          //  Thread.Sleep(2000); 
            
            amazonMethods.QuantityDropdown().Click();
           // Thread.Sleep(1000);

            amazonMethods.Quantity().Click();
           // Thread.Sleep(1000);
            
            amazonMethods.AddCart().Click();
           // Thread.Sleep(1000);

        }

        [Then(@"Open cart and assert total price and quantity are correct")]
        public void ThenOpenCartAndAssertTotalPriceAndQuantityAreCorrect()
        {
            amazonMethods.GotoCart().Click();
           // Thread.Sleep(1000);
            
            Assert.IsTrue(amazonMethods.TotalDetails().Displayed); ;
           // Thread.Sleep(1000);

            Assert.AreEqual(amazonMethods.TotalDetails().Text, amazonMethods.text);
            //Thread.Sleep(1000);

            Console.WriteLine(amazonMethods.TotalDetails().Text);
        }
      
        [When(@"search ""([^""]*)""")]
        public void WhenSearch(string item)
        {
            amazonMethods.SearchBox().SendKeys(item);
            // Thread.Sleep(1000);
        }

        [When(@"Add first hat to Cart with quantity one")]
        public void WhenAddFirstHatToCartWithQuantityOne()
        {
            amazonMethods.FirstWomenItem().Click();
            Thread.Sleep(1000);
            Assert.IsTrue(amazonMethods.QuantityOneWomen().Displayed);
            // Thread.Sleep(1000);
            Console.WriteLine("Quantity is displayed");

            Console.WriteLine(amazonMethods.QuantityOneWomen().Text);
        }
        [When(@"Click on the cart and check that quantity is correct")]
        public void WhenClickOnTheCartAndCheckThatQuantityIsCorrect()
        {
            amazonMethods.AddCart().Click();
            // Thread.Sleep(1000);

            Assert.IsTrue(amazonMethods.ItemDetails().Displayed); ;
            // Thread.Sleep(1000);

            Assert.AreEqual(amazonMethods.ItemDetails().Text, amazonMethods.text);
            //Thread.Sleep(1000);

            Console.WriteLine(amazonMethods.ItemDetails().Text);
        }
        [When(@"Change the quantity for item selected at step three from two to one item in Cart")]
        public void WhenChangeTheQuantityForItemSelectedAtStepThreeFromTwoToOneItemInCart()
        {
            amazonMethods.GotoCart().Click();
            // Thread.Sleep(1000);
           
            amazonMethods.QuantityRemoveDropdown().Click();
            // Thread.Sleep(1000);

            amazonMethods.Quantity().Click();
            //Thread.Sleep(1000);
            
          

            Assert.IsTrue(amazonMethods.FinalTotal().Displayed); ;
            // Thread.Sleep(1000);

            Assert.AreEqual(amazonMethods.FinalTotal().Text, amazonMethods.text);
            //Thread.Sleep(1000);

            Console.WriteLine(amazonMethods.FinalTotal().Text);


        }





    }
}
