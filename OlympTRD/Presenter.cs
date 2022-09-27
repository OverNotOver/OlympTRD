using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympTRD
{
    

    internal class Presenter
    {
        Model model;
        Form1 form1;
        

        public Presenter(Form1 form)
        {
            model = new Model();
            form1 = form;
            form1.ClickUp += Form1_ClickUp;
            form1.ClickDown += Form1_ClickDown;
            form1.Login += Form1_Login;
        }

        private void Form1_Login(object sender, EventArgs e)
        {
            model.Login();
        }

        private void Form1_ClickDown(object sender, EventArgs e)
        {
            model.MetodClickDown();    
        }

        private void Form1_ClickUp(object sender, EventArgs e)
        {
            model.MetodClikUp();
        }
    }
}
