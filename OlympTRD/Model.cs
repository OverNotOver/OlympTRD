using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OlympTRD
{
    internal class Model
    {
       
       
        public void MetodClikUp()
        {
            Form1.firefox.FindElement(By.XPath("//*[@id=\"page-container\"]/div/div[3]/main/div[2]/div[1]/div/div[1]/div/div/div[2]/div[2]/div/div/div[4]/div/button[1]")).Click();
            
        }

        public void MetodClickDown()
        {
            Form1.firefox.FindElement(By.XPath("//*[@id=\"page-container\"]/div/div[3]/main/div[2]/div[1]/div/div[1]/div/div/div[2]/div[2]/div/div/div[4]/div/button[2]")).Click();
        }

        public void Login()
        {
            Thread.Sleep(5000);
            string log = "shunko.trade@gmail.com";
            string pass = "Amsterdam7Kolian";
            Form1.firefox.FindElement(By.XPath("//button[@class='_633ZZh0WP6 jnFoUFrfoH']")).Click();
            Thread.Sleep(2000);
            Form1.firefox.FindElement(By.XPath("//input[@type='email']")).SendKeys(log);
            Form1.firefox.FindElement(By.XPath("//input[@type='password']")).SendKeys(pass);
            Thread.Sleep(10000);
            Form1.firefox.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(10000);
            Form1.firefox.FindElement(By.XPath("//button[@data-test='chart-menu']")).Click();
            Thread.Sleep(2000);
            Form1.firefox.FindElement(By.XPath("//button[@data-test='choose_chart/line']")).Click();
            Thread.Sleep(3000);
            Form1.firefox.FindElement(By.XPath("//button[@data-test='asset-select-button']")).Click();
            Thread.Sleep(2000);
            Form1.firefox.FindElement(By.XPath("//button[@data-test='trading-tabulator-tab-ftt']")).Click();
            Thread.Sleep(1000);
            Form1.firefox.FindElement(By.XPath("//div[text()='Asia Composite Index']")).Click();
            Thread.Sleep(3000);
            Form1.firefox.FindElement(By.XPath("//button[@data-test='cor-w-panel-close']")).Click();

        }
    }
}
