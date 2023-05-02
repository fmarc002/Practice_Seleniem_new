using OpenQA.Selenium;

namespace MyNewProjectToPractice.PageObjects
{
    public class DropDownPage : BasePageObject
    {
        public DropDownPage()
            : base(By.XPath(".//h3[. = 'Dropdown List']"))
        { }

        public By page = By.XPath(".//h3[. = 'Dropdown List']");
        public IWebElement DropDownOption => driver.FindElement(By.Id("dropdown"));
        //.//select[@id='dropdown']
    }
}