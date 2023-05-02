using OpenQA.Selenium;
using System.Collections.Generic;

namespace MyNewProjectToPractice.PageObjects
{
    public class AddDeleteElementPage : BasePageObject
    {
        public AddDeleteElementPage()
            : base(By.Id("content"))
        { }

        public IWebElement BtnAdd => driver.FindElement(By.XPath(".//button[contains(@onclick,'addElement')]"));
        public IList<IWebElement> BtnDelete => driver.FindElements(By.XPath(".//button[contains(@onclick,'deleteElement')]"));
    }
}