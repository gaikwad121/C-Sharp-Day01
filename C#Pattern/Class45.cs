using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumExample
{
	class Program
	{
		static void Main(string[] args)
		{
			// Launch Chrome browser
			IWebDriver driver = new ChromeDriver();

			try
			{
				// Maximize window
				driver.Manage().Window.Maximize();

				// Navigate to Google
				driver.Navigate().GoToUrl("https://www.google.com");

				// Find the search box and enter text
				IWebElement searchBox = driver.FindElement(By.Name("q"));
				searchBox.SendKeys("Dress Shop Management in C#");
				searchBox.Submit();

				// Wait for results to load
				Thread.Sleep(3000);

				// Print first 5 search results
				var results = driver.FindElements(By.CssSelector("h3"));
				Console.WriteLine("Top search results:");
				int count = 0;
				foreach (var result in results)
				{
					if (!string.IsNullOrEmpty(result.Text))
					{
						Console.WriteLine($"- {result.Text}");
						count++;
					}
					if (count >= 5) break;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				// Close browser
				driver.Quit();
			}
		}
	}
}
