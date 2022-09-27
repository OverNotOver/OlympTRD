using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympTRD
{
    internal class Model
    {
        

        public void MetodClikUp()
        {
            try
            {
                Form1.firefox.FindElement(By.XPath("//button[@data-test='deal-button-up']")).Click();
            }
            catch
            {

            }          
        }

     
        public void MetodClickDown()
        {
            try
            {
                Form1.firefox.FindElement(By.XPath("//button[@data-test='deal-button-down']")).Click();
            }
            catch
            {

            }
        }

        public void InputControlsMinus()
        {
                    
                Form1.firefox.FindElement(By.XPath("//button[@data-test='deal-form-input-controls-minus']")).Click();
        
        }
        public void InputControlsPlus()
        {

            Form1.firefox.FindElement(By.XPath("//button[@data-test='deal-form-input-controls-plus']")).Click();

        }

       
    }
}
