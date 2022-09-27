using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Keys = OpenQA.Selenium.Keys;


namespace OlympTRD
{
    public partial class Form1 : Form
    {
        public static FirefoxDriver firefox;
        public event EventHandler ClickUp = null;
        public event EventHandler ClickDown = null;
        public event EventHandler ClickPlus = null;
        public event EventHandler ClickMinus = null;
        public event EventHandler AddMoney = null;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = true;
            new Presenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickUp.Invoke(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClickDown.Invoke(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firefox != null) firefox.Quit();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitFirefox();
            firefox.Navigate().GoToUrl("https://olymptrade.com/platform");

            Thread thread = new Thread(Start);
            thread.Start();

        }

        public void Start()
        {
            Login();
            while (true)
            {

                //richTextBox1.Text = GetBase64Img();
                pictureBox1.Image = Base64ToImage(GetBase64Img().Substring(22));
                Thread.Sleep(2500);
            }

        }

        public void InitFirefox()
        {

            FirefoxDriverService servise = FirefoxDriverService.CreateDefaultService();
            servise.HideCommandPromptWindow = true;

            FirefoxOptions options = new FirefoxOptions();
            firefox = new FirefoxDriver(servise, options);





        }

        public void Login()
        {
            Thread.Sleep(5000);
            string log = "shunko.trade@gmail.com";
            string pass = "Amsterdam7Kolian";
            firefox.FindElement(By.XPath("//button[@class='_633ZZh0WP6 jnFoUFrfoH']")).Click();
            Thread.Sleep(2000);
            firefox.FindElement(By.XPath("//input[@type='email']")).SendKeys(log);
            firefox.FindElement(By.XPath("//input[@type='password']")).SendKeys(pass);
            Thread.Sleep(10000);
            firefox.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(10000);
            firefox.FindElement(By.XPath("//button[@data-test='chart-menu']")).Click();
            Thread.Sleep(2000);
            firefox.FindElement(By.XPath("//button[@data-test='choose_chart/line']")).Click();
            Thread.Sleep(3000);
            firefox.FindElement(By.XPath("//button[@data-test='asset-select-button']")).Click();
            Thread.Sleep(2000);
            firefox.FindElement(By.XPath("//button[@data-test='trading-tabulator-tab-ftt']")).Click();
            Thread.Sleep(1000);
            firefox.FindElement(By.XPath("//div[text()='Asia Composite Index']")).Click();
            Thread.Sleep(3000);
            firefox.FindElement(By.XPath("//button[@data-test='cor-w-panel-close']")).Click();

        }

       
        public string GetBase64Img()
        {
            try
            {
                string script = "var canvas = document.getElementById(\"chart-canvas-gb1gd\");\r\nvar image = canvas.toDataURL(\"image/png\");\r\nreturn (image);";
                IJavaScriptExecutor js = (IJavaScriptExecutor)firefox;
                string title = (string)js.ExecuteScript(script);
                return title;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
          
        }
        public Image Base64ToImage(string base64String)
        {
            try
            {
                // Convert base 64 string to byte[]
                byte[] imageBytes = Convert.FromBase64String(base64String);
                // Convert byte[] to Image
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    Image image = Image.FromStream(ms, true);
                    return image;
                }
            }
            catch
            {
                return null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClickPlus.Invoke(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClickMinus.Invoke(sender, e);
        }

    }
    
   
}
