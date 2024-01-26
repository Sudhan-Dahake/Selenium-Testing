/***************************
 * Assignment 2 - Part B
 * Course: CSCN72010-23F-Sec3 
 * Date: October 30, 2023
 * By: Sudhan Dahake
 ***************************/

namespace SeleniumTestingA2
{

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;


    // *******************************************
    // Testing : Province DropDown options working

    [TestClass]
    public class ProvinceDropDown_UnitTest
    // A Test class that contains all the test methods related to Province DropDown Menu
    {
        private string[] expectedAlphabeticalProvinceList = { "Alberta", "British Columbia", "New Brunswick", "Newfoundland", "NorthWest Territories", "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island", "Quebec", "Saskatchewan", "Yukon Territory" };
        // An array containing provinces in Alphabetical Order

        private string[] actualOrderProvinceList = { "Ontario", "Newfoundland", "Prince Edward Island", "Nova Scotia", "New Brunswick", "Quebec", "Saskatschewan", "Alberta", "British Columbia", "Yukon Territory", "NorthWest Territories", "Nunavut" };
        // An array that contains provinces in the actual order as present on the DropDown Menu

        IWebDriver driver;


        [TestMethod]
        public void Test_Alberta_Province_Results_SuccessfulRegistration()
        // Test method to check Alberta province
        // Checks if upon entering valid data on Registration page and clicking "Register Now", the successful Registration website opens
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);
            // To make sure our test runs sucessfully

            driver.Navigate().GoToUrl("https://localhost/register/index.html");
            // Making the driver navigate to the specified URL



            // Arrange

            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            // Finding the element which has ID "firstName" and storing the web element in firstNameField variable

            firstNameField.SendKeys("Suzbye");
            // sending the data to be inputted in the web element

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("Drift Street");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("NorthField");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            // Since a dropDown has many items, therefore we are using SelectElement to store that DropDown

            provinceDropDown.SelectByText("Alberta");
            // Selecting the province name by Text
            // It is worth mentioning here, that this will fail
            // This is because in the actual web application the spelling of Alberta is Wrong

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Suzbye@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("7");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            // Finding the register Button using ID

            registerButton.Click();
            // This "Register Now" button is clicked



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";

            String actualURL = driver.Url;
            // driver.Url will fetch us the current URL


            Assert.AreEqual(expectedURL, actualURL);
            // This will check if the both the variables have same value or not

            driver.Close();
            // Closing the driver (chrome window) upon succesful execution

        }


        [TestMethod]
        public void Test_BritishColumbia_Province_Results_SuccessfulRegistration()
        // This test fails because of the spelling error in the web application
        // In the web application, British Columbia is written as Columbia British, which is not correct.
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("SabzVery");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Smart");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("near College");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("British Columbia");
            // This will fail because the DropDown's List "Columbia British" is not equal to "British Columbia"
            // The order of the two words matter

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-433-5748");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("SabzSmartest@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("8");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_NewBrunswick_Province_Results_SuccessfulRegistration()
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Mi");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Novar");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("Conestoga Street");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("New Brunswick");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N6U 8P4");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-488-4875");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("mi@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("4");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_Newfoundland_Province_Results_SuccessfulRegistration()
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suz");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("abc");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Newfoundland");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sudhanguitarist@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_NorthWestTerritories_Province_Results_SuccessfulRegistration()
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sabzspeaks");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("farsi");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("in the world");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Kitchener");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("NorthWest Territories");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2M 5B1");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sabzfluentfarsi@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("9");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_NovaScotia_Province_Results_SuccessfulRegistration()
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sierra");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Erb");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("Erb Street");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Kitchener");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Nova Scotia");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N5I 8T4");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-854-4865");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("serb@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("1");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_Nunavut_Province_Results_SuccessfulRegistration()
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sabzgoodlooking");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("gorgeous");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("near college");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Nunavut");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("gorgeoussabz@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("11");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_Ontario_Province_Results_SuccessfulRegistration()
         // This test method is going to fail
         // This is because here we are Checking the alphabetical presence of Ontario in the DropDown List
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sudhan");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("xyz");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Ontario");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sdahake9382@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");

            Thread.Sleep(1000);



            // Act
            int expectedIndex = Array.IndexOf(expectedAlphabeticalProvinceList, "Ontario");
            // Getting the expected Index (the alphabetical one) from the Array

            int actualIndex = Array.IndexOf(actualOrderProvinceList, "Ontario");
            // Getting the actual Index (the one similar to the dropdown menu in the web application) from the array

            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedIndex, actualIndex);
            // Checking if the expected index is equal to the actual index or not
            // Here, they are NOT equl, which means the province Ontario is not in alphabetical order

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_PrinceEdwardIsland_Province_Results_SuccessfulRegistration()
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sabzu");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Sanchez");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("Columbia Street");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Prince Edward Island");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2J 6A5");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("512-549-4856");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sabzurocks@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_Quebec_Province_Results_SuccessfulRegistration()
        // This test method will fail
        // This is because here we are inputting Phone Number in the form (111)111-1111
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suzun");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dachshund");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("249 Eiffel Tower");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Quebec");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N4I 9R4");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("(226)875-1134");
            // Phone number is inputted in the form (111)111-1111
            // This form is valid

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("SausageBaby@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("16");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();
            // The test case will fail here, itself as our web application does not recognise (111)111-1111 as one of the valid formats for Phone Number



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_Saskatchewan_Province_Results_SuccessfulRegistration()
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suzbaba");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("Tokyo Drive");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("London");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Saskatchewan");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N4L 8T8");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("suzbaba@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_YukonTerritory_Province_Results_SuccessfulRegistration()
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sabzgoodvoice");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Singer");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("near Mc Donalds");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByText("Yukon Territory");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N5L 6T9");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("744-587-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sabzgreatsinger@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("9");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }
    }


    // *******************************
    // Testing "How many Participants"

    [TestClass]
    public class Participant_UnitTest
    {
        IWebDriver driver;

        [TestMethod]
        public void Test_NumberParticipants_1_Results_SuccessfulRegistration()
        // Here we are setting the number of participants to 1
        // Here our goal is to assert that upon entering valid data we can go to succesful registration page
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sudhan");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("xyz");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sdahake9382@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("1");
            // setting the number of participants to 1

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }


        [TestMethod]
        public void Test_NumberParticipants_2_Results_SuccessfulRegistration()
        // Here we are setting the number of participants to 2
        // Here our goal is to assert that upon entering valid data we can go to succesful registration page
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suz");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("abc");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NL");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sudhanguitarist@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");
            // setting the number of participants to 2

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }



        [TestMethod]
        public void Test_NumberParticipants_3_Results_SuccessfulRegistration()
        // Here we are setting the number of participants to 3
        // Here our goal is to assert that upon entering valid data we can go to succesful registration page
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sabzu");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Sanchez");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("Columbia Street");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("PE");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2J 6A5");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("512-549-4856");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sabzurocks@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("3");
            // setting the number of participants to 3

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }




        [TestMethod]
        public void Test_NumberParticipants_4_Results_SuccessfulRegistration()
        // Here we are setting the number of participants to 4
        // Here our goal is to assert that upon entering valid data we can go to succesful registration page
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sierra");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Erb");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("Erb Street");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Kitchener");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NS");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N5I 8T4");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-854-4865");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("serb@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("4");
            // setting the number of participants to 4

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }



        [TestMethod]
        public void Test_NumberParticipants_5_Results_SuccessfulRegistration()
        // Here we are setting the number of participants to 5
        // Here our goal is to assert that upon entering valid data we can go to succesful registration page
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Mi");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Novar");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("Conestoga Street");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NB");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N6U 8P4");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-488-4875");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("mi@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("5");
            // setting the number of participants to 5

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }



        [TestMethod]
        public void Test_NumberParticipants_6_Results_SuccessfulRegistration()
        // Here we are setting the number of participants to 6
        // Here our goal is to assert that upon entering valid data we can go to succesful registration page
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sudhan");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("xyz");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("QC");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sdahake9382@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("6");
            // setting the number of participants to 6

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();



            // Assert
            String expectedURL = "https://localhost/register/viewRegistration.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }
    }


    // *************************************************************************
    // Testing : The amount Registrants will be charged based on the day

    [TestClass]
    public class RegistrationDayCharge_UnitTest
    
    {
        IWebDriver driver;

        [TestMethod]
        public void Test_RegistrationDay_1_NumberParticipants_1_Results_Price_450()
        // Registrants attending Day 1 and number of participants 1 should be charged $450
        // This test method will fail as the price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sudhan");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("xyz");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sdahake9382@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("1");
            // setting the number of participants as 1

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");
            // setting the Day as Day 1

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);

            String expectedPrice = "$450";
            // This is our expected price for Day 1 and 1 participant

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");
            // getting the actual value as displayed in our web application


            String expectedTextDisplayedDay = "Day 1";
            // Here we are also checking if on the webpage correct Day is displayed or not

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;
            // Retrieving the Day number as displayed on the Successful Registration page



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);
            // checking if the actual and the expected price are the same or not
            // 

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);
            // Checking if the expected Day and actual Day displayed on the web page are same or not

            driver.Close();

        }


        [TestMethod]
        public void Test_RegistrationDay_1_NumberParticipants_2_Results_Price_900()
        // Registrants attending Day 1 and number of participants 2 should be charged $900
        // This test method will fail as the price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suz");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("abc");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NL");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sudhanguitarist@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");
            // setting number of participants as 2

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");
            // setting the day as day 1

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);

            String expectedPrice = "$900";

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");


            String expectedTextDisplayedDay = "Day 1";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);

            driver.Close();

        }


        [TestMethod]
        public void Test_RegistrationDay_1_NumberParticipants_3_Results_Price_1350()
        // Registrants attending Day 1 and number of participants 1 should be charged $1350
        // This test method will fail as the price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sihak");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("sin");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("sdfj");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("PE");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sihak@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("3");
            // setting the number of participants as 3

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");
            // setting the day as Day 1

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);

            String expectedPrice = "$1350";

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");


            String expectedTextDisplayedDay = "Day 1";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);

            driver.Close();

        }





        [TestMethod]
        public void Test_RegistrationDay_2_NumberParticipants_1_Results_Price_350()
        // Registrants attending Day 2 and participants 1 will be charged $350
        // This test case will fail because of 2 reasons:
        // 1. The expected and the actual price is not correct.
        // 2. In the successful registration window, the Day is not correct. Instead of displaying "Day 2" the webpage displays "Day 3"
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sudhan");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("xyz");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sdahake9382@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("1");
            // setting the number of participants as 1

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");
            // setting the day as Day 2

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);



            String expectedPrice = "$350";

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");



            String expectedTextDisplayedDay = "Day 2";
            // setting expected Day that is displayed on successful registration page as Day 2

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;
            // Retrieving the actual Day that is displayed



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);
            // Fails because price does not match

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);
            // Failed because the day is not correct

            driver.Close();

        }

        [TestMethod]
        public void Test_RegistrationDay_2_NumberParticipants_2_Results_Price_700()
        // Registrants attending Day 2 and participants 2 will be charged $700
        // This test case will fail because of 2 reasons:
        // 1. The expected and the actual price is not correct.
        // 2. In the successful registration window, the Day is not correct. Instead of displaying "Day 2" the webpage displays "Day 3"
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suz");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("abc");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NL");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sudhanguitarist@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");
            // setting the number of participants to 2

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");
            // setting the day as Day 2

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);




            String expectedPrice = "$700";
            // the expected Price for 2 participants and Day 2 is 700

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");



            String expectedTextDisplayedDay = "Day 2";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;



            // Assert

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);
            // Fails because the Day displayed on the Successful registration web page is incorrect

            Assert.AreEqual(expectedPrice, actualPrice);
            // Fails because price doesn't match

            driver.Close();

        }



        [TestMethod]
        public void Test_RegistrationDay_2_NumberParticipants_3_Results_Price_1050()
        // Registrants attending Day 2 and participants 1 will be charged $1050
        // This test case will fail because of 2 reasons:
        // 1. The expected and the actual price is not correct.
        // 2. In the successful registration window, the Day is not correct. Instead of displaying "Day 2" the webpage displays "Day 3"
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sihak");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("sin");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("sdfj");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("PE");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sihak@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("3");
            // setting the number of participants as 3

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");
            // setting the Day as Day 2

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);




            String expectedPrice = "$1050";

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");


            String expectedTextDisplayedDay = "Day 2";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);

            driver.Close();

        }


        


        [TestMethod]
        public void Test_RegistrationDay_BothDays_NumberParticipants_1_Results_Price_750()
        //Registrants attending both Day 1 and Day 2 and number of participants equals 1 will be charged $750
        // This test case will fail because:
        // The expected and the actual price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sudhan");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("xyz");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sdahake9382@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("1");
            // setting the number of participants to 1

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");
            // setting the day as Both days

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);



            String expectedPrice = "$750";
            // the expected price for 1 participant and both days is $750

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");
            // getting the actual price displayed on the webpage



            String expectedTextDisplayedDay = "Both days";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;
            // Getting the day displayed on the successful registration webpage



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);
            // This assert will fail

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);
            // This assert will pass
            // Checking if the Day displayed on the successful registration webpage is correct or not

            driver.Close();

        }


        [TestMethod]
        public void Test_RegistrationDay_BothDays_NumberParticipants_2_Results_Price_1500()
        //Registrants attending both Day 1 and Day 2 and number of participants equals 2 will be charged $1500
        // This test case will fail because:
        // The expected and the actual price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suz");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("abc");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NL");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sudhanguitarist@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");
            // setting the number of participants as 2

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");
            // setting the Day as Both Days

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);




            String expectedPrice = "$1500";

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");



            String expectedTextDisplayedDay = "Both days";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);

            driver.Close();

        }


        [TestMethod]
        public void Test_RegistrationDay_BothDays_NumberParticipants_3_Results_Price_2250()
        //Registrants attending both Day 1 and Day 2 and number of participants equals 3 will be charged $2250
        // This test case will fail because:
        // The expected and the actual price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sihak");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("sin");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("sdfj");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("PE");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sihak@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("3");
            // setting the number of participants as 3

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");
            // setting the Day as Both Days

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);




            String expectedPrice = "$2250";

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");


            String expectedTextDisplayedDay = "Both days";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);

            driver.Close();

        }
    }


    // *********************************************************************************************************
    // Testing : Registrants registering more than five participants will be given a 10% discount (3 test cases)

    [TestClass]
    public class ParticipantDiscount_UnitTest
    {
        IWebDriver driver;

        [TestMethod]
        public void Test_RegistrationDay_Day_1_NumberParticipants_7_Results_Ten_Percent_Discount()
        // This test method is used for Day 1 and Number of Participants 7
        // This test method will fail, because the discounted price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sudhan");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("xyz");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sdahake9382@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("7");
            // setting number of participants as 7

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");
            // setting the day as Day 1

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);



            String expectedPrice = "$2835";
            // The expected value calculation is done like this:
            // 450 * 7 * 0.9
            // This applies the 10% discount

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");
            // Getting the actual price from the successful registration webpage



            String expectedTextDisplayedDay = "Day 1";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;
            // Getting the Day displayed on the successful registration webpage



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);
            // This will fail as the discounted price is not the same in expected and actual

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);
            // This Assert will pass

            driver.Close();

        }



        [TestMethod]
        public void Test_RegistrationDay_Day_2_NumberParticipants_10_Results_Ten_Percent_Discount()
        // This test method is used for Day 2 and Number of Participants 10
        // This test method will fail, because the discounted price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suz");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("abc");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("NL");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sudhanguitarist@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("10");
            // setting the number of participants as 10

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");
            // setting the day as Day 2

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);




            String expectedPrice = "$3150";
            // The expected value calculation is done like this:
            // 350 * 10 * 0.9
            // This applies the 10% discount

            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");



            String expectedTextDisplayedDay = "Day 2";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);
            // This assert fails because the discounted price is not same in expected and actual

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);
            // This assert also fails because the Day displayed on webpage is Day 3 not Day 2

            driver.Close();

        }


        [TestMethod]
        public void Test_RegistrationDay_BothDays_NumberParticipants_12_Results_Ten_Percent_Discount()
        // This test method is used for Both days and Number of Participants 12
        // This test method will fail, because the discounted price is not correct
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sihak");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("sin");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("sdfj");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("PE");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-348-5496");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sihak@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("12");
            // setting the number of participants as 12

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("both");
            // setting the day as Both Days

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);




            String expectedPrice = "$8100";
            // The expected value calculation is done like this:
            // 750 * 12 * 0.9
            // This applies the 10% discount


            IWebElement answer = driver.FindElement(By.Id("price"));
            String actualPrice = answer.GetAttribute("value");


            String expectedTextDisplayedDay = "Both days";

            IWebElement dayNumber = driver.FindElement(By.Id("daysRegistered"));
            SelectElement textBoxDayNumber = new SelectElement(dayNumber);

            String actualTextDisplayedDay = textBoxDayNumber.SelectedOption.Text;



            // Assert

            Assert.AreEqual(expectedPrice, actualPrice);
            // This assert fails because the price is not the same in expected and actual

            Assert.AreEqual(expectedTextDisplayedDay, actualTextDisplayedDay);
            // This assert passes

            driver.Close();

        }
    }


    // ********************************************************************************
    // Testing : Links are to be provided and working from Successful Registration page

    [TestClass]
    public class TopPageLink_UnitTest
    {
        IWebDriver driver;

        [TestMethod]
        public void Test_THEEVENT_present_working_Returns_RegistrationPage()
        // This test method tests that the Link is to be provided and working for THE EVENT!
        // This test method will pass
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Sudhan");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("xyz");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6P2");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("Sdahake9382@conestogac.on.ca");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("2");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day1");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);

            IWebElement eventButton = driver.FindElement(By.ClassName("navbar-brand"));
            // Finding the Event button using the ClassName
            eventButton.Click();
            // Clicking on the button


            Thread.Sleep(5000);

            // Assert
            String expectedURL = "https://localhost/register/index.html";
            // This is URL we are hoping to get once the Button is triggered

            String actualURL = driver.Url;
            // Getting the actual URL of the webpage we are currently on

            Assert.AreEqual(expectedURL, actualURL);
            // This assert will pass
            // Checking to see if both of them are same

            driver.Close();

        }




        [TestMethod]
        public void Test_Home_present_working_Returns_RegistrationPage()
        // This test method tests that the Link is to be provided and working for Home Page
        // This test method will pass
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suz");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dahake");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("abc");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("Waterloo");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("PE");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 6F4");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("225-668-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("sudhandahake12@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("4");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);

            IWebElement eventButton = driver.FindElement(By.ClassName("nav-link"));
            // Finding the Home button using the ClassName

            eventButton.Click();
            // Clicking on the button


            Thread.Sleep(5000);

            // Assert
            String expectedURL = "https://localhost/register/index.html";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);
            // This assert will pass

            driver.Close();

        }




        [TestMethod]
        public void Test_ConestogaCollege_present_working_inViewRegistrationHTML_Returns_Conestoga_MainPage()
        // This test method tests that the Link is to be provided and working for Conestoga main page
        // This test method will fail
        {

            ChromeOptions handlingSSL = new ChromeOptions();
            handlingSSL.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(handlingSSL);

            driver.Navigate().GoToUrl("https://localhost/register/index.html");



            // Arrange
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Suzun");

            Thread.Sleep(1000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Dachshund");

            Thread.Sleep(1000);


            IWebElement addressField = driver.FindElement(By.Id("address"));
            addressField.SendKeys("249 eliffel tower");

            Thread.Sleep(1000);


            IWebElement cityField = driver.FindElement(By.Id("city"));
            cityField.SendKeys("London");

            Thread.Sleep(1000);


            SelectElement provinceDropDown = new SelectElement(driver.FindElement(By.Id("province")));
            provinceDropDown.SelectByValue("ON");

            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("postalCode"));
            postalCodeField.SendKeys("N2L 5K4");

            Thread.Sleep(1000);


            IWebElement phoneNumberField = driver.FindElement(By.Id("phone"));
            phoneNumberField.SendKeys("226-456-7456");

            Thread.Sleep(1000);


            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("dachshundSausageBaby@gmail.com");

            Thread.Sleep(1000);


            IWebElement numParticipantsField = driver.FindElement(By.Id("numberOfParticipants"));
            numParticipantsField.SendKeys("3");

            Thread.Sleep(1000);


            SelectElement dayRegistrationDropDown = new SelectElement(driver.FindElement(By.Id("daysRegistered")));
            dayRegistrationDropDown.SelectByValue("day2");

            Thread.Sleep(1000);



            // Act
            IWebElement registerButton = driver.FindElement(By.Id("btnSubmit"));
            registerButton.Click();

            Thread.Sleep(5000);

            IWebElement conestogaButton = driver.FindElement(By.LinkText("Link To Conestoga College"));
            // Finding the conestoga button using the ClassName
            // This will fail because we don't have any conestoga button that links to Conestoga College's Main page in the Successful Registration page

            conestogaButton.Click();



            Thread.Sleep(5000);

            // Assert
            String expectedURL = "https://www.conestogac.on.ca/about/corporate-information/policies";
            String actualURL = driver.Url;

            Assert.AreEqual(expectedURL, actualURL);

            driver.Close();

        }
    }
}