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
    public class Keyboard_DOB
    {
        public void Key_dob(IWebDriver driver, char character)
        {
            if (character.Equals('1'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[1]/span");

            if (character.Equals('2'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[2]/span");

            if (character.Equals('3'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[3]/span");

            if (character.Equals('4'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[4]/span");

            if (character.Equals('5'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[5]/span");

            if (character.Equals('6'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[6]/span");

            if (character.Equals('7'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[7]/span");

            if (character.Equals('8'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[8]/span");

            if (character.Equals('9'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[9]/span");

            if (character.Equals('0'))
                Click(driver, "//*[@id='field_data_nascimento_keyboard']/div/button[10]/span");
        }

        public void Click(IWebDriver driver, string XPath)
        {
            IWebElement webElement = driver.FindElement(By.XPath(XPath));

            if (!webElement.Displayed)
            {
                Console.WriteLine("Não é exibido");
                Thread.Sleep(3000);
                webElement = driver.FindElement(By.XPath(XPath));
                Thread.Sleep(3000);

            }

            webElement.Click();
        }
    }
}