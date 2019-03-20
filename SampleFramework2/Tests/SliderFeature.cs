using System;
using NUnit.Framework;

namespace SampleFramework2
{
    public class SliderFeature : BaseTest
    {
        [Test]
        [Description("Validate that slider changes images")]
        [Property("Author", "ArCiGo")]
        public void TCID3()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            var currentImage = homePage.Slider.CurrentImage;
            homePage.Slider.ClickNextButton();

            var newImage = homePage.Slider.CurrentImage;

            Assert.AreNotEqual(currentImage, newImage,
                "The slider images didn't change when pressing the next button");
        }
    }
}
