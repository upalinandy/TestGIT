using OpenQA.Selenium;
using SpecFramework.GlobalParam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFramework.ActionClasses
{
    public class UIActions
    {
        /*
        public static void GoToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);

        }*/

        public static void GoToUrl(string url)
        {
            ObjectRepo.driver.Navigate().GoToUrl(url);

        }
        /*
        public static void Click(IWebDriver driver, By elem)
        {
            driver.FindElement(elem).Click();
        }*/

        public static void Click(By elem)
        {
            ObjectRepo.driver.FindElement(elem).Click();
        }

    }
    }
