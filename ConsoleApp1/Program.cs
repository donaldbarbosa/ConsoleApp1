using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //abre aplicação

            IWebDriver driver = new InternetExplorerDriver(@"C:\Users\donald.barbosa\source\Project\ConsoleApp1\IEDriver");
            
            driver.Navigate().GoToUrl("https://service.e-component.com/kioskdcs/kioskframe.html?platform=kioskole&plugin=dcsws");

            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//*[@id='outerFr']")).Click();

            IWebElement frameset = driver.FindElement(By.XPath("//*[@id='dynamicFrame']"));

            driver.SwitchTo().Frame(frameset);

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("/html/body/div[1]")).Click();

            Thread.Sleep(2000);

            

                     

            //Clica no checkin

            IWebElement checkin = driver.FindElement(By.XPath("//*[@id='mm_txtCheckin']"));

            Thread.Sleep(2000);

            if(!checkin.Displayed)
            {
                Console.WriteLine("Not displayed");
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("/html/body/div[1]")).Click();
                Thread.Sleep(3000);
                
            }

            Thread.Sleep(6000);

            checkin.Click();

            //busca por localizador

            IWebElement localizador = driver.FindElement(By.XPath("//*[@id='mm_txtRecordLocator']"));

            localizador.Click();

            //IWebElement key1 = driver.FindElement(By.XPath("//*[@id='wrap']/div/div/button[1]/span"));

            //key1.Click();

            //solicita o localizador pelo console

            //Console.WriteLine("Localizador: ");

            Thread.Sleep(4000);

            string loc = "GRSBUB";

            Keyboard_Locator key = new Keyboard_Locator();

            IWebElement field_localizador = driver.FindElement(By.XPath("//*[@id='btnNextrecordLocator']/div/div"));

            Thread.Sleep(4000);

            foreach (char charcter in loc.ToUpper())
            {
                 key.Key_loc(driver, charcter);
            }

            //insere o localizador e busca o localizador 

            IWebElement Continuar_localizador = driver.FindElement(By.Id("btnNextrecordLocator"));

            Continuar_localizador.Click();

            //clica em continuar 
            //só funciona com 1 pax

            IWebElement pax_continuar = driver.FindElement(By.Id("btnNextSelectPassenger"));

            pax_continuar.Click();

            //escolhe o RG e clica para continuar

            Thread.Sleep(2000);

            IWebElement rg_doc = driver.FindElement(By.Id("btn-identidade-RG"));

            rg_doc.Click();

            IWebElement docrg_continuar = driver.FindElement(By.Id("btnNextDocumentOptions"));

            docrg_continuar.Click();

            //Insere RG

            Console.WriteLine("RG: ");

            string rg = Console.ReadLine();

            IWebElement field_numero_documento = driver.FindElement(By.Id("field_numero_documento"));

            field_numero_documento.SendKeys(rg);

            IWebElement rg_continuar = driver.FindElement(By.Id("btnNextDocumentNumber"));

            rg_continuar.Click();

            //DOB

            //IWebElement bt1 = driver.FindElement(By.CssSelector(".ui-keyboard-button.ui-keyboard-1.ui-state-default.ui-corner-all.btnKeysDateOfBirth"));

            //Thread.Sleep(4000);

            //bt1.Click();

            Console.WriteLine("DOB: ");

            string dob = Console.ReadLine();

            IWebElement field_data_nascimento = driver.FindElement(By.Id("field_data_nascimento"));

            //field_data_nascimento.SendKeys(dob);

            IWebElement dob_continuar = driver.FindElement(By.Id("btnNextDateOfBirth"));                

            //teclado dob

            Keyboard_DOB birth = new Keyboard_DOB();

            foreach (char charcter in dob)
            {
                birth.Key_dob(driver, charcter);

            }

            dob_continuar.Click();

        }
    }
}