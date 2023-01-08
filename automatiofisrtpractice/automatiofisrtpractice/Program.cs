using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace automatiofisrtpractice
{
    public class Program
    {
      
            [Test]
            public void test1()
            {
            ChromeDriver chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("https://my.apexstage.xyz/login");


            Thread.Sleep(7000);
            chrome.FindElement(By.Name("apexchat-company")).Click();

            chrome.FindElement(By.Name("apexchat-company")).SendKeys("vendormax");

            chrome.FindElement(By.Id("apexchat-username")).Click();
            chrome.FindElement(By.Id("apexchat-username")).SendKeys("imran");

            chrome.FindElement(By.Id("apexchat-password")).Click();
            chrome.FindElement(By.Id("apexchat-password")).SendKeys("123456");

            chrome.FindElement(By.XPath("//button[text()='Login']")).Click();

            Thread.Sleep(7000);
        }
           

        
    }
}