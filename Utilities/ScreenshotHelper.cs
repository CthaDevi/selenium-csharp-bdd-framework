using OpenQA.Selenium;
using System;
using System.IO;

namespace SeleniumCSharpBDDFramework.Utilities
{
    public static class ScreenshotHelper
    {
        public static void CaptureScreenshot(IWebDriver driver, string scenarioName)
        {
            try
            {
                var takesScreenshot = (ITakesScreenshot)driver;
                var screenshot = takesScreenshot.GetScreenshot();

                string reportsFolder = Path.Combine(Directory.GetCurrentDirectory(), "Reports");

                if (!Directory.Exists(reportsFolder))
                {
                    Directory.CreateDirectory(reportsFolder);
                }

                string fileName = $"{scenarioName}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                string filePath = Path.Combine(reportsFolder, fileName);

                screenshot.SaveAsFile(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Screenshot capture failed: " + ex.Message);
            }
        }
    }
}
