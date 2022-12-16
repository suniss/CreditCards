﻿using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CreditCard.UITests
{
    public class CreditCardWebAppShould
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicatuibPage()
        {
            using (IWebDriver driver = new ChromeDriver()) 
            {
                driver.Navigate().GoToUrl("http://localhost:44108/");
            }

        }
    }
}
