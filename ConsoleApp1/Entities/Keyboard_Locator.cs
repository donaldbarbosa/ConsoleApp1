using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace ConsoleApp1.Entities
{
    public class Keyboard_Locator
    { 

        public void Key_loc(IWebDriver driver, char character)
        {
            if (character.Equals('1'))
                Click(driver, "//*[@id='wrap']/div/div/button[1]/span");

            if (character.Equals('2'))
                Click(driver, "//*[@id='wrap']/div/div/button[2]/span");

            if (character.Equals('3'))
                Click(driver, "//*[@id='wrap']/div/div/button[3]/span");

            if (character.Equals('4'))
                Click(driver, "//*[@id='wrap']/div/div/button[4]/span");

            if (character.Equals('5'))
                Click(driver, "//*[@id='wrap']/div/div/button[5]/span");

            if (character.Equals('6'))
                Click(driver, "//*[@id='wrap']/div/div/button[6]/span");

            if (character.Equals('7'))
                Click(driver, "//*[@id='wrap']/div/div/button[7]/span");

            if (character.Equals('8'))
                Click(driver, "//*[@id='wrap']/div/div/button[8]/span");

            if (character.Equals('9'))
                Click(driver, "//*[@id='wrap']/div/div/button[9]/span");

            if (character.Equals('0'))
                Click(driver, "//*[@id='wrap']/div/div/button[10]/span");

            if (character.Equals('Q'))
                Click(driver, "//*[@id='wrap']/div/div/button[11]/span");

            if (character.Equals('W'))
                Click(driver, "//*[@id='wrap']/div/div/button[12]/span");

            if (character.Equals('E'))
                Click(driver, "//*[@id='wrap']/div/div/button[13]/span");

            if (character.Equals('R'))
                Click(driver, "//*[@id='wrap']/div/div/button[14]/span");

            if (character.Equals('T'))
                Click(driver, "//*[@id='wrap']/div/div/button[15]/span");

            if (character.Equals('Y'))
                Click(driver, "//*[@id='wrap']/div/div/button[16]/span");

            if (character.Equals('U'))
                Click(driver, "//*[@id='wrap']/div/div/button[17]/span");

            if (character.Equals('I'))
                Click(driver, "//*[@id='wrap']/div/div/button[18]/span");

            if (character.Equals('O'))
                Click(driver, "//*[@id='wrap']/div/div/button[19]/span");

            if (character.Equals('P'))
                Click(driver, "//*[@id='wrap']/div/div/button[20]/span");

            if (character.Equals('A'))
                Click(driver, "//*[@id='wrap']/div/div/button[21]/span");

            if (character.Equals('S'))
                Click(driver, "//*[@id='wrap']/div/div/button[22]/span");

            if (character.Equals('D'))
                Click(driver, "//*[@id='wrap']/div/div/button[23]/span");

            if (character.Equals('F'))
                Click(driver, "//*[@id='wrap']/div/div/button[24]/span");

            if (character.Equals('G'))
                Click(driver, "//*[@id='wrap']/div/div/button[25]/span");

            if (character.Equals('H'))
                Click(driver, "//*[@id='wrap']/div/div/button[26]/span");

            if (character.Equals('J'))
                Click(driver, "//*[@id='wrap']/div/div/button[27]/span");

            if (character.Equals('K'))
                Click(driver, "//*[@id='wrap']/div/div/button[28]/span");

            if (character.Equals('L'))
                Click(driver, "//*[@id='wrap']/div/div/button[29]/span");

            if (character.Equals('Z'))
                Click(driver, "//*[@id='wrap']/div/div/button[30]/span");

            if (character.Equals('X'))
                Click(driver, "//*[@id='wrap']/div/div/button[31]/span");

            if (character.Equals('C'))
                Click(driver, "//*[@id='wrap']/div/div/button[32]/span");

            if (character.Equals('V'))
                Click(driver, "//*[@id='wrap']/div/div/button[33]/span");

            if (character.Equals('B'))
                Click(driver, "//*[@id='wrap']/div/div/button[34]/span");

            if (character.Equals('N'))
                Click(driver, "//*[@id='wrap']/div/div/button[35]/span");

            if (character.Equals('M'))
                Click(driver, "//*[@id='wrap']/div/div/button[36]/span");


            //Botão para apagar
            //IWebElement bksp = driver.FindElement(By.XPath("//*[@id='wrap']/div/div/button[37]/span"));

        }

        public void Click(IWebDriver driver, string xPath)
        {
            //if (driver.FindElement(By.XPath(xPath)).Displayed && driver.FindElement(By.XPath(xPath)).Enabled)
            //{
            //    driver.FindElement(By.XPath(xPath)).Click();
            //}
            //else
            //{
            //    Thread.Sleep(2000);

            //    driver.FindElement(By.XPath(xPath)).Click();
            //}

            IWebElement webElement = driver.FindElement(By.XPath(xPath));

            if (!webElement.Displayed)
            {
                Debug.Write("Não está displayed");

                Thread.Sleep(3000);
                webElement = driver.FindElement(By.XPath(xPath));
                Thread.Sleep(3000);
            }

            webElement.Click();
        }
    }
}
