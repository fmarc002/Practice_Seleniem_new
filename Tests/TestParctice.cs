using MyNewProjectToPractice.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;
using System.Threading;

namespace MyNewProjectToPractice.Tests
{
    public class TestParctice : BaseTests
    {
        protected Actions Actions => new Actions(Driver);

        //Where_DoingWhat_ExpectedResult
        [Test]
        public void Home_ValidateTitle_TitleContainsExpectedText()
        {
            HomePage home = new HomePage();
            home.Displayed();
            Assert.True(home.LblTitle.Text.Contains("Welcome"));
        }

        [Test]
        public void AddDeleteElement()
        {
            HomePage home = new HomePage();
            home.BtnAddDelete.Click();
            AddDeleteElementPage element = new AddDeleteElementPage();
            element.Displayed();
            for (int i = 0; i < 3; i++)
            {
                if (element.BtnAdd.Enabled)
                {
                    element.BtnAdd.Click();
                }
            }

            Assert.True(element.BtnDelete.Count().Equals(3));

            var c = element.BtnDelete.ToList();

            foreach (var i in c)
            {
                i.Click();
            }

            Assert.True(element.BtnDelete.Count().Equals(0));
        }

        [Test]
        public void CheckElement()
        {
            HomePage home = new HomePage();
            home.BtnCheckBoxes.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Checkboxes checkboxes = new Checkboxes();
            checkboxes.Displayed();

            foreach (var checkbox in checkboxes.ChexBoxes)
            {
                if (checkbox.Selected == false)
                {
                    checkbox.Click();
                }
                else
                {
                    this.Actions.DoubleClick(checkbox);
                }
            }
            Assert.True(checkboxes.ChexBoxes.All(checkbox => checkbox.Selected == true));
        }

        [Test]
        public void SelectDropdown()
        {
            HomePage home = new HomePage();
            home.BtnDropDown.Click();
            Thread.Sleep(3000);

            DropDownPage dropdown = new DropDownPage();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(dropdown.page));
            Assert.IsTrue(dropdown.Displayed());
            SelectElement selectElement = new SelectElement(dropdown.DropDownOption);
            if (!selectElement.SelectedOption.GetAttribute("selected").Equals("selected"))
            {
                selectElement.SelectByValue("1");
            }

            Assert.AreEqual(selectElement.SelectedOption.Text, "Option 1");
        }
    }
}