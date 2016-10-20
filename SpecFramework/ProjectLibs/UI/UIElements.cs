using OpenQA.Selenium;
using SpecFramework.CommonUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFramework.ProjectLibs.UI
{
   public class UIElements :PageBase

    {
        public By signin = By.XPath(".//*[contains(text(),'Sign In')]");
        public By rider_signin = By.XPath(".//*[contains(text(),'Rider sign in')]");
    }
}
