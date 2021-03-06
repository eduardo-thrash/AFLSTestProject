﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace CommonTest.CommonTest
{
    public class CommonElementsAction
    {
        ///<summary> Global variables
        ///
        ///     IWebElement ElementWait = Inicializador de un elemento del DOM
        ///     Exception Ex = Objeto de tipo excepción para errores que se generen
        ///     string Error = Texto del mensaje de error
        ///     int second = variable de segundos a esperar para generar un error
        ///
        ///</summary>
        public static IWebElement ElementWait;

        public static Exception Ex;
        public static string Error;
        public static int second;

        ///<summary> AccessPage
        /// Método para acceder a una pagina especifica y maximizar la pantalla.
        ///     string Url: URL a la cual se accederá
        ///
        ///</summary>
        public static void AccessPage(string Url)
        {
            CommonHooks.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            CommonHooks.driver.Navigate().GoToUrl(Url);
        }

        ///<summary> Click
        /// Método para identificar y hacer click sobre un elemento
        ///     string ElementType: Tipo de localizador (CssSelector, XPath, Id, Name, ClassName)
        ///     string Element: Elemento sobre el que se hará click
        ///
        /// </summary>
        public static void Click(string ElementType,string Element)
        {
            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Element));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Element));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Element));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Element));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    ElementWait.Click();
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        ///<summary> SendKeys_InputText
        /// Método para identificar y escribir texto en un campo de tipo input.
        ///     string ElementType: CssSelector, XPath, Id, Name, ClassName
        ///     string Input: Elemento de UIMap
        ///     string Value: Information or text for field
        ///
        /// </summary>
        public static void SendKeys_InputText(string ElementType,string Input,string Value)
        {
            for(second = 0;;second++)
            {
                if(second >= 15) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    ElementWait.Click();
                    ElementWait.SendKeys(Value);
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        ///<summary> ClearAndSendKeys_InputText
        /// Método para limpiar campo e ingresar información, util al modificar un texto de un campo.
        ///    string ElementType: XPath, ClassName, Name, Id, CSSSelector
        ///     string Input: UIMap Input
        ///     string Value: text on the input
        ///
        /// </summary>
        public static void ClearAndSendKeys_InputText(string ElementType,string Input,string Value)
        {
            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    ElementWait.Click();
                    ElementWait.Clear();
                    ElementWait.SendKeys(Value);
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        ///<summary> EnterAfterSendKeys_InputText
        /// Método para ingresar texto en campo y despues pulsar enter.
        ///     string ElementType: XPath, ClassName, Name, Id, CssSelector
        ///     string Input: UIMap Input
        ///     string Value: text on the input
        ///
        /// </summary>
        public static void EnterAfterSendKeys_InputText(string ElementType,string Input,string Value)
        {
            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    ElementWait.Click();
                    ElementWait.SendKeys(Value);
                    ElementWait.SendKeys(Keys.Enter);
                    Thread.Sleep(2000);
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Método para ingresar texto en campo de tipo busqueda por autocomplete y despues seleccionar una opción
        ///     string ElementType: XPath, ClassName, Name, Id, CssSelector
        ///     string List: UIMap List
        ///     string Option: Option for search
        ///     string tag: Tag of HTML (label,a,div,input,ul,etc)
        ///
        /// </summary>
        public static void Select_ComboboxAutocomplete(string ElementType,string List,string Option,string tag)
        {
            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(List));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(List));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(List));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(List));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(List));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    ElementWait.Click();
                    ElementWait.SendKeys(Option);
                    Thread.Sleep(2000);
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    ElementWait = CommonHooks.driver.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    ElementWait.Click();
                    Thread.Sleep(2000);
                    break;
                }
                catch(Exception)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        public static void ClickAndSelect_Random_ComboboxAutocomplete(string ElementType,string Select,string Option)
        {
            IWebElement SelectElement = CommonHooks.driver.FindElement(By.XPath(Select));
            SelectElement.SendKeys(" ");
            Thread.Sleep(2000);

            IList<IWebElement> AllOptions = CommonHooks.driver.FindElements(By.XPath(Option));
            int NumOptions = AllOptions.Count;

            Random rnd = new Random();
            int NumRandom = rnd.Next(1,NumOptions);
            int start = 1;

            foreach(IWebElement Elements in AllOptions)
            {
                if(start == NumRandom)
                {
                    for(second = 0;;second++)
                    {
                        if(second >= 10) Assert.Fail(Error);
                        try
                        {
                            Assert.IsTrue(Elements.Enabled);
                            Assert.IsTrue(Elements.Displayed);
                            Assert.AreNotEqual(Elements.Size,0);
                            Elements.Click();
                            Thread.Sleep(2000);
                            break;
                        }
                        catch(Exception Ex)
                        {
                            Error = Ex.Message;
                            Thread.Sleep(1000);
                        }
                    }
                }
                start++;
            }
        }

        #region Select DropDown List

        public static void ClickAndSelect_DropDownList(string ElementType,string List,string Option,string tag)
        {
            /*Método para dar click en un listado de opciones y despues seleccionar una opción*/

            //string ElementType: XPath, ClassName, Name, Id, CSSSelector
            //string List: UIMap List
            //string Option: Option for search
            //string tag: Tag of HTML (label,a,div,input,etc)
            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(List));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(List));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(List));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(List));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(List));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CSS" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CSS, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Ex.ToString());
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    ElementWait.Click();

                    Thread.Sleep(2000);

                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(int second = 0;;second++)
            {
                if(second >= 5) Assert.Fail(Error);
                try
                {
                    ElementWait = CommonHooks.driver.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);

                    ElementWait.Click();
                    Thread.Sleep(2000);
                    break;
                }
                catch(Exception)
                { Thread.Sleep(1000); }
            }
        }

        #endregion Select DropDown List

        #region Clear

        ///<summary> Clear
        ///
        /// </summary>
        public static void Clear(string ElementType,string Input)
        {
            // string ElementType: CSS, XPath, Id, Name, ClassName
            // string Element: Elemento de UIMap
            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CSS" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CSS, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Ex.ToString());
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    ElementWait.Clear();
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        #endregion Clear

        #region Use Texts

        ///<summary> TextExtract
        ///
        /// </summary>
        public static string TextExtract(string ElementType,string Input)
        {
            /*Método para extraer texto entre una etiqueta. Ejemplo: <label> Texto </label>*/

            // string ElementType: CSS, XPath, Id, Name, ClassName
            // string Input: Elemento de UIMap

            string Text;

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CSS" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CSS, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    Text = ElementWait.Text;
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            return Text;
        }

        ///<summary> VallueExtract
        ///
        /// </summary>
        public static string VallueExtract(string ElementType,string Input)
        {
            string Value;

            /*Método para extraer texto entre una etiqueta. Ejemplo: <input value:"Texto">*/

            // string ElementType: CSS, XPath, Id, Name, ClassName
            // string Input: Elemento de UIMap
            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    switch(ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch(Exception Ex)
                {
                    if(ElementType != "CSS" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CSS, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    Value = ElementWait.GetAttribute("value");
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            return Value;
        }

        #endregion Use Texts

        #region SwitchTo

        ///<summary>
        ///
        /// </summary>
        public static void EnterSwitchToiFrame()
        {
        }

        public static void CloseSwitchTiFrame()
        {
        }

        ///<summary>
        ///
        /// </summary>
        public static void ClickAndSwitchToNewTab()
        {
        }

        #endregion SwitchTo

        #region Select and/or Click random list

        ///<summary>
        ///
        /// </summary>

        #endregion Select and/or Click random list

        #region Select option of dropdown list

        public static void ClickAndSelect_Random_DropDownList(string ElementType,string Select,string Option)
        {
            IWebElement SelectElement = CommonHooks.driver.FindElement(By.XPath(Select));
            SelectElement.Click();
            Thread.Sleep(2000);

            IList<IWebElement> AllOptions = CommonHooks.driver.FindElements(By.XPath(Option));
            int NumOptions = AllOptions.Count;

            Random rnd = new Random();
            int RandomNum = rnd.Next(1,NumOptions);
            int start = 1;

            foreach(IWebElement Elements in AllOptions)
            {
                if(start == RandomNum)
                {
                    for(second = 0;;second++)
                    {
                        if(second >= 10) Assert.Fail(Error);
                        try
                        {
                            Assert.IsTrue(Elements.Enabled);
                            Assert.IsTrue(Elements.Displayed);
                            Assert.AreNotEqual(Elements.Size,0);
                            Elements.Click();
                            Thread.Sleep(2000);
                            break;
                        }
                        catch(Exception Ex)
                        {
                            Error = Ex.Message;
                            Thread.Sleep(1000);
                        }
                    }
                }
                start++;
            }
        }

        #endregion Select option of dropdown list

        #region Select random option of List

        public static string ClickOn_Random_List(string ElementType,string Option)
        {
            string TextOption = "";
            IList<IWebElement> AllOptions = CommonHooks.driver.FindElements(By.XPath(Option));
            Thread.Sleep(1000);
            int NumOptions = AllOptions.Count;

            Random rnd = new Random();
            int numeroConDosCotas = rnd.Next(1,NumOptions);
            int start = 1;

            foreach(IWebElement Elements in AllOptions)
            {
                if(start == numeroConDosCotas)
                {
                    TextOption = Elements.Text;
                    Elements.Click();
                }
                start++;
            }
            return TextOption;
        }

        #endregion Select random option of List

        ///<summary> Drag and Drop
        ///
        /// </summary>

        ///<summary> ExtractNumberOfText
        /// Método para extraer número de una cadena de texto
        ///     string Text: Texto del que se extraera el número.
        /// </summary>
        public static string ExtractNumberOfText(string Text)
        {
            Match number = Regex.Match(Text,"(\\d+)");
            string result = Convert.ToString(number);
            return result;
        }

        ///<summary> WaitElement
        /// Método para esperar que este disponible un elemento sin realizar ninguna acción sobre él.
        ///     string Element = Localizador Xpath del elemento.
        /// </summary>
        ///
        public static void WaitElement(string Element)
        {
            for(second = 0;;second++)
            {
                if(second >= 10) Assert.Fail(Error);
                try
                {
                    ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size,0);
                    Thread.Sleep(2000);
                    break;
                }

                catch(Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }
    }
}