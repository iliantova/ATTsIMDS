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
   
    public class New_user : Common
    {
   [Test]
        public void New_userSetUpTest()
   {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("Вход в системата")).Click();
            driver.FindElement(By.Id("UserName")).Clear();
            driver.FindElement(By.Id("UserName")).SendKeys("Administrator");
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("12345678");
            driver.FindElement(By.XPath(".//*[@id='content-container']/form/div/div[1]/div[2]/div[5]/input")).Click();
            driver.FindElement(By.XPath("html/body/div[3]/div[1]/div/ul/li[10]/a")).Click();
            driver.FindElement(By.XPath("//li[3]/a/span")).Click();
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
            driver.FindElement(By.XPath("//input[@value='Началник отдел']")).SendKeys("Началник отдел");
            driver.FindElement(By.XPath("//input[@value='Цвятко']")).Clear();
            driver.FindElement(By.XPath("//input[@value='Цвятко']")).SendKeys("Цвятко");
            driver.FindElement(By.XPath("//input[@value='Цветков']")).Clear();
            driver.FindElement(By.XPath("//input[@value='Цветков']")).SendKeys("Цветков");
            driver.FindElement(By.XPath("//input[@value='t.tsvetkov@cnsys.bg']")).Clear();
            driver.FindElement(By.XPath("//input[@value='t.tsvetkov@cnsys.bg']")).SendKeys("t.tsvetkov@cnsys.bg");
            driver.FindElement(By.XPath("//input[@value='0888500501']")).Clear();
            driver.FindElement(By.XPath("//input[@value='0888500501']")).SendKeys("0888500501");
            driver.FindElement(By.XPath("//input[@value='T.Tsvetkov']")).Clear();
            driver.FindElement(By.XPath("//input[@value='T.Tsvetkov']")).SendKeys("T.Tsvetkov");
            driver.FindElement(By.XPath("//img[@title='Избор на роли']")).Click();
            driver.FindElement(By.Id("6")).Click();
            driver.FindElement(By.Id("1")).Click();
            driver.FindElement(By.Id("17")).Click();
            driver.FindElement(By.Id("4")).Click();
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
