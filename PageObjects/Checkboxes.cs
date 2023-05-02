using OpenQA.Selenium;
using System.Collections.Generic;

namespace MyNewProjectToPractice.PageObjects
{
    public class Checkboxes : BasePageObject
    {
        public Checkboxes()
            : base(By.XPath(".//h3[. = 'Checkboxes']"))
        { }

        public IList<IWebElement> ChexBoxes => driver.FindElements(By.CssSelector("input[type='checkbox']"));
    }
}