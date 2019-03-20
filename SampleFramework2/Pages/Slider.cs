using System;
using OpenQA.Selenium;

namespace SampleFramework2
{
    public class Slider : BaseApplicationPage
    {
        public Slider(IWebDriver driver) : base(driver) { }

        public string CurrentImage => MainSliderImage.GetAttribute("style");

        private IWebElement MainSliderImage => Driver.FindElement(By.Id("homeslider"));

        public void ClickNextButton()
        {
            Driver.FindElement(By.ClassName("bx-next")).Click();
        }
    }
}
