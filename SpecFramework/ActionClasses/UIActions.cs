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
        public static void GoToUrl(string url)
        {
            ObjectRepo.driver.Navigate().GoToUrl(url);

        }
        
        public static void Click(By elem)
        {
            ObjectRepo.driver.FindElement(elem).Click();
        }

        public static string getTitle()
        {
            return ObjectRepo.driver.Title;
        }

    }
    }
