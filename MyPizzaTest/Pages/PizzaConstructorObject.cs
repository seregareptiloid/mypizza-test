﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyPizzaTest.Pages
{
    public class PizzaConstructorObject : Page
    {
        public PizzaConstructorObject(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

         
        public bool IsTestFinished()
        {
            return driver.FindElements(By.XPath("//a[text()='В корзину']")).Count > 0;
        }

        public void AddToCart()
        {
            arwAddQuantity.Click();
            btnAddToCart.Click();
        }

        IWebElement btnAddToCart => driver.FindElement(By.XPath("//a[text()='В корзину']"));
        IWebElement arwAddQuantity => driver.FindElement(By.CssSelector("#modal  span.c-menu__arrow.c-menu__arrow--plus"));



    }
}
