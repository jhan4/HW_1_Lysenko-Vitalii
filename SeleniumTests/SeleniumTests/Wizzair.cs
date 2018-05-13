using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Wizzair
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            driver = new ChromeDriver(@"E:\Downloads\WebDriver");
            driver.Navigate().GoToUrl("https://wizzair.com");
        }

        [OneTimeTearDown]
        public void GoAway()
        {
            driver.Quit();
        }


        [Test, Order(1), Retry(2), Description("Wizzair ticket order")]
        public void SearchFlights()
        {
            
            WebDriverWait PageLoadWaiting = new WebDriverWait(driver, TimeSpan.FromSeconds(180));
            
            //Place Choosing
            IWebElement SearchDepartureStation = driver.FindElement(By.Id("search-departure-station"));
            SearchDepartureStation.Clear();
            SearchDepartureStation.SendKeys("Kiev");
            SearchDepartureStation.SendKeys(Keys.Enter);

            IWebElement DestinationPoint = driver.FindElement(By.Id("search-arrival-station"));
            DestinationPoint.Clear();
            DestinationPoint.SendKeys("Copenhagen");
            DestinationPoint.SendKeys(Keys.Enter);

            //Date Choosing
            IWebElement Set_Out_Date = driver.FindElement(By.XPath("//td[not(class='is-disabled')]/button"));
            Set_Out_Date.Click();
                    
             IWebElement DateOkButton = PageLoadWaiting.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains(@class,'shrinkable')]")));
             DateOkButton.Click();

             //SearchButton
             IWebElement SearchButton = driver.FindElement(By.XPath("//button[contains(@class, 'panel__cta-btn')]"));
             SearchButton.Click();

             //New browser tab opening
             driver.SwitchTo().Window(driver.WindowHandles[1]);

             //Date Verifying
             IWebElement SelectedDate = PageLoadWaiting.Until(ExpectedConditions.ElementExists(By.CssSelector(".js-selected.js-selectable > label > div > time")));
             string DateActual = SelectedDate.Text;
             string DateExpected = "Fri 14, May";
             StringAssert.AreEqualIgnoringCase(DateExpected, DateActual, "Date should be set to Friday 14, May");

             //Basic Option is displayed
             IWebElement BasicOption = driver.FindElement(By.XPath("//p[contains (@class, 'header__title') and text() = 'Basic']"));
             bool BasicOptionDisplayed = BasicOption.Displayed;
             Assert.True(BasicOptionDisplayed);

            //Basic Prcie is displayed
            IWebElement BasicElementPrice = driver.FindElement(By.XPath("//td[contains (@class, 'column--basic')]//strong"));
             bool B_ElementPriceDisplayed = BasicElementPrice.Displayed;
             Assert.True(B_ElementPriceDisplayed);

            //WizzGo Option is displayed
            IWebElement WizzGoOption = driver.FindElement(By.XPath("//p[contains (@class, 'header__title') and text() = 'WIZZ Go']"));
             bool WizzGoOptionDisplayed = WizzGoOption.Displayed;
             Assert.True(WizzGoOptionDisplayed);

            //WizzGo Price is displayed
            IWebElement WizzGoElementPrice = driver.FindElement(By.XPath("//td[contains (@class, 'column--middle')]//strong"));
             bool WG_ElementPriceDisplayed = WizzGoElementPrice.Displayed;
             Assert.True(WG_ElementPriceDisplayed);

            // WizzPlus Option is displayed
            IWebElement WizzPlusOption = driver.FindElement(By.XPath("//p[contains (@class, 'booking-flow') and text() = 'WIZZ Plus']"));
             bool WizzPlusOptionDisplayed = WizzPlusOption.Displayed;
             Assert.True(WizzPlusOptionDisplayed);

            //WizzPlus Price is displayed
            IWebElement WizzPlusElementPrice = driver.FindElement(By.XPath("//td[contains (@class, 'column--plus')]//strong"));
             bool WP_ElementPriceDisplayed = WizzPlusElementPrice.Displayed;
             Assert.True(WP_ElementPriceDisplayed);

             //TariffPlan choosing
             IWebElement Offer = driver.FindElement(By.XPath("//label[contains(@class, 'main')]"));
             Offer.Click();

             IWebElement ContinueButton = driver.FindElement(By.Id("flight-select-continue-btn"));
             ContinueButton.Click();

             //First Nmae, Last Name, Luggage
             IWebElement FirstNameField = PageLoadWaiting.Until(ExpectedConditions.ElementExists(By.Id("passenger-first-name-0")));
             FirstNameField.SendKeys("Vitalii");
             IWebElement LastNameField = driver.FindElement(By.Id("passenger-last-name-0"));
             LastNameField.SendKeys("Lysenko");
             IWebElement SexMaleField = driver.FindElement(By.CssSelector(".rf-switch--input-sized > label:nth-child(4)"));
             SexMaleField.Click();

             IWebElement Luggage = driver.FindElement(By.CssSelector(".rf-switch__label.baggage-switcher--1 > span.rf-switch__icon-container"));
             Luggage.Click();

            //Verifying that 1 passenger chosen
            IWebElement Passenger = driver.FindElement(By.XPath("//div[contains (@class, 'flow__itinerary__pax')]"));
            string El_Passenger = Passenger.Text;
            Assert.AreEqual("1 PASSENGER", El_Passenger, "1 Passenger should be set");

            //Route Verifying
            IWebElement SpecifiedPath = driver.FindElement(By.CssSelector("span.flight-info__stations"));
             bool SpecifiedPathIsDisplayed = SpecifiedPath.Displayed;
             Assert.That(SpecifiedPathIsDisplayed, Is.True, "Path <<Kiev - Zhulyany - Copenhagen>> should be displayed");
             string ActualPath = SpecifiedPath.Text;
             string ExpectedPath = "Kiev - Zhulyany - Copenhagen";
             Assert.AreEqual(ExpectedPath, ActualPath, "Path should be set to <<Kiev - Zhulyany - Copenhagen>>");

             IWebElement ContinueButton2 = driver.FindElement(By.Id("passengers-continue-btn"));
             ContinueButton2.Click();

             //Sign In Form
             IWebElement SignInForm= PageLoadWaiting.Until(ExpectedConditions.ElementIsVisible(By.Id("login-modal")));
             bool SignInFormDisplayed = SignInForm.Displayed;
             Assert.True(SignInFormDisplayed, "Signin should be displayed");
        }      
    }
    
}
