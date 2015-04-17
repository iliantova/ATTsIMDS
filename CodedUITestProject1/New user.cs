using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using CodedUITestProject1;

namespace IISDA_Test_cases
{
   
    public class New_user2 : Common
    {
   [Test]
        public void New_userSetUpTest()
   {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("Вход в системата")).Click();
            driver.FindElement(By.Id("UserName")).Clear();
            driver.FindElement(By.Id("UserName")).SendKeys(Input.InputText(1,1));
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys(Input.InputText(1,3));
            driver.FindElement(By.XPath(".//*[@id='content-container']/form/div/div[1]/div[2]/div[5]/input")).Click();
            driver.FindElement(By.XPath("html/body/div[3]/div[1]/div/ul/li[10]/a")).Click();
            Thread.Sleep(2000); 
            driver.FindElement(By.XPath("//li[3]/a/span")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("span.ng-binding")).Click();
            driver.FindElement(By.XPath("//div[2]/div/ul/li[3]/a/span")).Click();
            driver.FindElement(By.CssSelector("img.icon.ng-scope")).Click();
            new SelectElement(driver.FindElement(By.XPath("//select"))).SelectByText("Администрация на Министерски съвет");
            driver.FindElement(By.XPath("//input[@value='Търси']")).Click();
            driver.FindElement(By.Name("rbGroup")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.CssSelector("div.ng-binding.ng-isolate-scope > img.icon.ng-scope")).Click();
            driver.FindElement(By.LinkText("звено2")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[5]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[5]/input")).SendKeys("Началник отдел");
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[7]/input")).Clear();
            //driver.FindElement(By.XPath(@"id('content-container')/x:div/x:div[2]/x:div[2]/x:div[2]/x:div[1]/x:div[7]/x:input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[7]/input")).SendKeys(Input.InputText(2,1));
            //driver.FindElement(By.XPath(@"id('content-container')/x:div/x:div[2]/x:div[2]/x:div[2]/x:div[1]/x:div[7]/x:input")).SendKeys("Цвятко");
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[9]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[9]/input")).SendKeys(Input.InputText(2, 2));    
       //   driver.FindElement(By.XPath("//input[@value='Цветков']")).Clear();
       //   driver.FindElement(By.XPath("//input[@value='Цветков']")).SendKeys("Цветков");
            //driver.FindElement(By.XPath("//input[@value='t.tsvetkov@cnsys.bg']")).Clear();
            //driver.FindElement(By.XPath("//input[@value='t.tsvetkov@cnsys.bg']")).SendKeys("t.tsvetkov@cnsys.bg");
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[10]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[10]/input")).SendKeys(Input.InputText(2, 4));    
            //driver.FindElement(By.XPath("//input[@value='0888500501']")).Clear();
            //driver.FindElement(By.XPath("//input[@value='0888500501']")).SendKeys("0888500501");
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[11]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[11]/input")).SendKeys(Input.InputText(2, 3));
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[13]/input")).Clear();
            driver.FindElement(By.XPath(".//*[@id='content-container']/div/div[2]/div[2]/div[2]/div[1]/div[13]/input")).SendKeys(Input.InputText(2, 5));         
       //driver.FindElement(By.XPath("//input[@value='T.Tsvetkov']")).Clear();
       //     driver.FindElement(By.XPath("//input[@value='T.Tsvetkov']")).SendKeys("T.Tsvetkov");
            driver.FindElement(By.XPath("//img[@title='Избор на роли']")).Click();
            driver.FindElement(By.XPath(".//*[@id='content-container']/div[10]/div/div/div/div/div/div[2]/div[2]/div/div[1]/div[1]")).Click();   
            driver.FindElement(By.Id("6")).Click();
            //driver.FindElement(By.Id("1")).Click();
            //driver.FindElement(By.Id("17")).Click();
            //driver.FindElement(By.Id("4")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.XPath("//img[@title='Избор на заповеди']")).Click();
            driver.FindElement(By.XPath("(//input[@type='text'])[8]")).Clear();
            driver.FindElement(By.XPath("(//input[@type='text'])[8]")).SendKeys("1");
            driver.FindElement(By.Id("orderFile")).Clear();
            driver.FindElement(By.Id("orderFile")).SendKeys("C:\\Users\\t.tsvetkov\\Desktop\\SUNAU TC_ver 0.4.xlsx");
            driver.FindElement(By.XPath("//div[2]/div/div[2]/div[2]/button")).Click();
            driver.FindElement(By.Id("-7")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.XPath("(//img[@title='Избор на заповеди'])[2]")).Click();
            driver.FindElement(By.Id("-7")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.XPath("(//img[@title='Избор на заповеди'])[3]")).Click();
            driver.FindElement(By.Id("-7")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.XPath("(//img[@title='Избор на заповеди'])[4]")).Click();
            driver.FindElement(By.Id("-7")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.CssSelector("td.ng-binding > img.icon.ng-scope")).Click();
            driver.FindElement(By.CssSelector("a.calendar-icon")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[21]")).Click();
            driver.FindElement(By.XPath("(//a[contains(@href, 'javascript:void(0)')])[4]")).Click();
            driver.FindElement(By.XPath("(//button[@type='button'])[73]")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.CssSelector("td.action-column.ng-scope > img.icon.ng-scope")).Click();
            driver.FindElement(By.XPath("//img[@title='Избор на роли']")).Click();
            driver.FindElement(By.Id("6")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.XPath("(//img[@title='Избор на заповеди'])[4]")).Click();
            driver.FindElement(By.Id("-7")).Click();
            driver.FindElement(By.XPath("//div[3]/button")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();

        }
    }
}
