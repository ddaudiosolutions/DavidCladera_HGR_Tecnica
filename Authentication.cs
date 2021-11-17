using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//USAMOS SELENIUM PARA HACER SCRAPPING PUES NOS SIRVE PARA HACER TEST SOBRE UN WEBROWSER.
//EN ESTE CASO HE UTILIZADO CRHOMRDRIVER

namespace HustGotReal_Tech
{
    class Authentication {

        public static String baseUrl = "https://app.hustlegotreal.com/Account/Login";
        public static String scrappingUrl = "https://app.hustlegotreal.com";
        public static String email = "testing@hustlegotreal.com";
        public static String pass = "HGR2021";
        
       public static void Login(){

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);

            var emailIn = driver.FindElement(By.Name("Email"));
            var passWordIn = driver.FindElement(By.Name("Password"));

            emailIn.SendKeys(email);
            passWordIn.SendKeys(pass);

            passWordIn.Submit();
            

            driver.Navigate().GoToUrl(scrappingUrl);

            var contenido0 = driver.FindElement(By.XPath("//div[@class='module_products']//div[@class='col-sm-6 sector']//p[1]"));    
            var contenido1 = driver.FindElement(By.XPath("//div[@class='module_products']//div[@class='col-sm-6 sector']//p[2]"));

            String result0 = contenido0.Text;
            String result = contenido1.Text;

            TakeText.takeText(result0, result); //EJECUTAMOS EL ARCHIVO TAKETEXT, PARA IMPRIMIR EN CONSOLA EL TEXTO PEDIDO

            
        }
    
    }
}
