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
            
            //Route Choosing
            IWebElement SearchDepartureStation = driver.FindElement(By.Id("search-departure-station"));
            SearchDepartureStation.Clear();
            SearchDepartureStation.SendKeys("Kiev");
            SearchDepartureStation.SendKeys(Keys.Enter);
            string Departure_Stattion = SearchDepartureStation.Text;

            IWebElement DestinationPoint = driver.FindElement(By.Id("search-arrival-station"));
            DestinationPoint.Clear();
            DestinationPoint.SendKeys("Copenhagen");
            DestinationPoint.SendKeys(Keys.Enter);
            string Destination_Point = DestinationPoint.Text;

            //Date Choosing
            IWebElement Set_Out_Date = driver.FindElement(By.Id("search-departure-date"));
            string Verified_Set_Out_Date = Set_Out_Date.Text;
            DateTime Verified_Set_Out_Date1 = DateTime.Parse(Verified_Set_Out_Date);

            //Passenger Field
            IWebElement Pas_Field = driver.FindElement(By.Id("search-passenger"));
            Pas_Field.Click();
            IWebElement Pas_Field_Ok_Button = driver.FindElement(By.CssSelector("[class*=done-btn] > button"));
            Pas_Field_Ok_Button.Click();

            //SearchButton
            IWebElement SearchButton = driver.FindElement(By.XPath("//button[contains(@class, 'panel__cta-btn')]"));
             SearchButton.Click();

             //New browser tab opening
             driver.SwitchTo().Window(driver.WindowHandles[1]);

            //Date Verification
            IWebElement FlyingDate = PageLoadWaiting.Until(Flying_Date => Flying_Date.FindElement(By.CssSelector("td > time")));
            string Correct_FlightDate = FlyingDate.Text;
            DateTime Correct_FlightDate1 = DateTime.Parse(Correct_FlightDate);
            Assert.That(Verified_Set_Out_Date1, Is.EqualTo(Correct_FlightDate1), "Selected date on Search form should be equal to date on Search results page");

            //Verifying the Departure and Destination points  
            IWebElement SpecifiedRoute = driver.FindElement(By.XPath("//div[contains(@class,'outbound')]/div/address"));
            string SpecifiedPath = SpecifiedRoute.Text;
            Assert.That(SpecifiedPath, Does.Contain(Departure_Stattion), "Flying route should contain correct Departure station");
            Assert.That(SpecifiedPath, Does.Contain(Destination_Point), "Flying route should contain correct Destination point");

            //Verifying that  the flying date is selected
            IWebElement SelectedDate = driver.FindElement(By.CssSelector(".js-selected.js-selectable > label > div > time"));
            string DateActual = SelectedDate.Text;
            DateTime DateActual1 = DateTime.Parse(DateActual);
            Assert.AreEqual(DateActual1, Verified_Set_Out_Date1);

            //The Block of Basic Option and its price is displayed
            IWebElement BasicOption = driver.FindElement(By.CssSelector("[class*=table__content__column--basic]"));
             bool BasicOptionDisplayed = BasicOption.Displayed;
             Assert.True(BasicOptionDisplayed);

            //The Block of WizzGo Option and its price is displayed
            IWebElement WizzGoOption = driver.FindElement(By.CssSelector("[class*=table__content__column--middle]"));
             bool WizzGoOptionDisplayed = WizzGoOption.Displayed;
             Assert.True(WizzGoOptionDisplayed);

            // The Block ofWizzPlus Option and its price is displayed
            IWebElement WizzPlusOption = driver.FindElement(By.CssSelector("[class*=table__content__column--plus]"));
             bool WizzPlusOptionDisplayed = WizzPlusOption.Displayed;
             Assert.True(WizzPlusOptionDisplayed);

             //Tariff Plan choosing
             IWebElement Offer = driver.FindElement(By.XPath("//label[contains(@class, 'main')]"));
             Offer.Click();

             IWebElement ContinueButton = driver.FindElement(By.Id("flight-select-continue-btn"));
             ContinueButton.Click();

             //First Nmae, Last Name, Luggage
             IWebElement FirstNameField = PageLoadWaiting.Until(First_Name_Field=> First_Name_Field.FindElement(By.Id("passenger-first-name-0")));
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

             IWebElement ContinueButton2 = driver.FindElement(By.Id("passengers-continue-btn"));
             ContinueButton2.Click();

             //Sign In Form
             IWebElement SignInForm= PageLoadWaiting.Until(Sign_In_Form=> Sign_In_Form.FindElement(By.Id("login-modal")));
             bool SignInFormDisplayed = SignInForm.Displayed;
             Assert.True(SignInFormDisplayed, "Signin should be displayed");
        }      
    }
    
}
