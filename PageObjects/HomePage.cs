using OpenQA.Selenium;

namespace MyNewProjectToPractice.PageObjects
{
    public class HomePage : BasePageObject
    {
        public HomePage()
            : base(By.XPath(".//body"))
        { }

        public IWebElement LblTitle => driver.FindElement(By.CssSelector(".heading"));
        public IWebElement BtnAddDelete => driver.FindElement(By.XPath(".//a[contains(.,'Add/Remove Element')]"));
        public IWebElement BtnCheckBoxes => driver.FindElement(By.XPath(".//a[contains(.,'Checkboxes')]"));
        public IWebElement BtnDropDown => driver.FindElement(By.XPath(".//a[contains(.,'Dropdown')]"));
    }
}