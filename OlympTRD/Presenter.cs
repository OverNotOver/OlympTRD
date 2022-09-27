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
            form1.ClickMinus += Form1_ClickMinus;
            form1.ClickPlus += Form1_ClickPlus;
        
        }

        private void Form1_ClickPlus(object sender, EventArgs e)
        {
            model.InputControlsPlus();
        }

        private void Form1_ClickMinus(object sender, EventArgs e)
        {
            model.InputControlsMinus();
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
