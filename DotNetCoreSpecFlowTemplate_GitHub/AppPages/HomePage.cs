using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetCoreSpecFlowTemplate.AppPages
{
    public class HomePage : BasePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.GetDriver(), this);
        }

        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")]
        public IWebElement SearchBar { get; set; }
        public string Title = "Google";
    }
}
