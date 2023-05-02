using OpenQA.Selenium;

namespace MyNewProjectToPractice.PageObjects
{
    public class BasePageObject
    {
        protected IWebDriver driver;
        protected By locator;

        public BasePageObject(By locator)
        {
            this.driver = BaseTests.Driver;
            this.locator = locator;
        }

        public IWebElement Container
        {
            get
            {
                try
                {
                    return this.driver.FindElement(this.locator);
                }
                catch
                {
                    return null;
                }
            }
        }

        public bool Displayed()
        {
            try
            {
                return this.Container.Displayed;
            }
            catch
            {
                return false;
            }
        }

        public bool Enabled()
        {
            try
            {
                return this.Container.Enabled;
            }
            catch
            {
                return false;
            }
        }
    }
}