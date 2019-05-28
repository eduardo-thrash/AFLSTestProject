﻿using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Configuration;
using AFLSUIProjectTest.UIMap.Messages;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUITestProject.TestSuite.Configuration.Configuration
{
    [Binding]
    public class AFServicesSteps
    {
        private readonly AFServicesPage AFServicesPage = new AFServicesPage();
        private readonly PageMessages PageMessages = new PageMessages();
        private string AFServiceName;
        private string DefaultAFServiceName = "UI AFService Simple";
        private string EditAFServiceName;
        private string EditLabelAFServiceName = "UI Edit AFService Simple";
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private string LabelAFServiceName;
        private AFLSUIProjectTest.UIMap.ConfigurationMenuPage Menu = new AFLSUIProjectTest.UIMap.ConfigurationMenuPage();
        private MessagesElements Messages = new MessagesElements();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private ResponseValidation Validation = new ResponseValidation();
        private string Label;
        private int OrderField;
        private int CountOptions;

        [Given(@"Existe el campo adicional de servicio de tipo simple")]
        public string GivenExisteElCampoAdicionalDeServicioDeTipoSimple()
        {
            AFServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 1 ORDER BY NEWID();", 1);
            return AFServiceName;
        }

        [Given(@"No existe el campo adicional de servicio de tipo fecha")]
        public void GivenNoExisteElCampoAdicionalDeServicioDeTipoFecha()
        {
            AFServiceName = DefaultAFServiceName + Functions.RandomText(4);
            LabelAFServiceName = AFServiceName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 4 AND name = '" + AFServiceName + "';", 0);
        }

        [Given(@"No existe el campo adicional de servicio de tipo listado")]
        public void GivenNoExisteElCampoAdicionalDeServicioDeTipoListado()
        {
            AFServiceName = DefaultAFServiceName + Functions.RandomText(4);
            LabelAFServiceName = AFServiceName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 5 AND name = '" + AFServiceName + "';", 0);
        }

        [Given(@"No existe el campo adicional de servicio de tipo numérico")]
        public void GivenNoExisteElCampoAdicionalDeServicioDeTipoNumerico()
        {
            AFServiceName = DefaultAFServiceName + Functions.RandomText(4);
            LabelAFServiceName = AFServiceName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 2 AND name = '" + AFServiceName + "';", 0);
        }

        [Given(@"No existe el campo adicional de servicio de tipo párrafo")]
        public void GivenNoExisteElCampoAdicionalDeServicioDeTipoParrafo()
        {
            AFServiceName = DefaultAFServiceName + Functions.RandomText(4);
            LabelAFServiceName = AFServiceName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 6 AND name = '" + AFServiceName + "';", 0);
        }

        [Given(@"No existe el campo adicional de servicio de tipo simple")]
        public string GivenNoExisteElCampoAdicionalDeServicioDeTipoSimple()
        {
            AFServiceName = DefaultAFServiceName + Functions.RandomText(4);
            LabelAFServiceName = AFServiceName;
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 1 AND name = '" + AFServiceName + "';", 0);
            return AFServiceName;
        }

        [Then(@"Se borra el registro de el campo adicional de servicio en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeBorraElRegistroDeElCampoAdicionalDeServicioEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 1 AND name = '" + AFServiceName + "';", 0);
        }

        [Then(@"Se elimina el registro de campo adicional de servicio de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeEliminaElRegistroDeCampoAdicionalDeServicioDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se modifican datos de campo adicional de servicio de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeModificanDatosDeCampoAdicionalDeServicioDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 1 AND name = '" + AFServiceName + "' AND label = '" + EditLabelAFServiceName + "';", 1);
        }

        [Then(@"Se muestra un mensaje indicando que se creo que campo adicional correctamente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeCreoQueCampoAdicionalCorrectamente()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Se muestra un mensaje indicando que se creo que campo adicional de servicio correctamente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeCreoQueCampoAdicionalDeServicioCorrectamente()
        {
            Validation.ValidationSuccessAFCreate(Messages.ResponseSuccessAFClient);
        }

        [Then(@"Se muestra un mensaje indicando que se guardo que campo adicional correctamente")]
        public void ThenSeMuestraUnMensajeIndicandoQueSeGuardoQueCampoAdicionalCorrectamente()
        {
            string Error = null;
            string Message = null;
            for (int second = 0; ; second++)
            {
                if (second >= 10) Assert.Fail(Error);
                try
                {
                    Message = CommonHooks.driver.FindElement(By.XPath("//div[@class='flag js-flag-box success']/p")).Text;
                    break;
                }
                catch (Exception e)
                {
                    Error = e.Message;
                    try
                    {
                        Message = CommonHooks.driver.FindElement(By.XPath("//div[@class='flag js-flag-box error']/p")).Text;
                        Assert.Fail(Message);
                    }
                    catch { Thread.Sleep(1000); }
                }
            }
        }

        [Then(@"Se registra campo adicional de servicio de tipo fecha en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeServicioDeTipoFechaEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 4 AND name = '" + AFServiceName + "';", 1);
        }

        [Then(@"Se registra campo adicional de servicio de tipo listado en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeServicioDeTipoListadoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 5 AND name = '" + AFServiceName + "';", 1);
        }

        [Then(@"Se registra campo adicional de servicio de tipo numérico en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeServicioDeTipoNumericoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 2 AND name = '" + AFServiceName + "';", 1);
        }

        [Then(@"Se registra campo adicional de servicio de tipo párrafo en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeServicioDeTipoParrafoEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 6 AND name = '" + AFServiceName + "';", 1);
        }

        [Then(@"Se registra campo adicional de servicio de tipo simple en tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraCampoAdicionalDeServicioDeTipoSimpleEnTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND type_id = 1 AND name = '" + AFServiceName + "';", 1);
        }

        [Then(@"Se registra el campo adicional de servicio modificado en la tabla AFW_ADDiTIONAL_FIELDS")]
        public void ThenSeRegistraElCampoAdicionalDeServicioModificadoEnLaTablaAFW_ADDiTIONAL_FIELDS()
        {
            CommonQuery.DBSelectAValue("SELECT name FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34003 AND type_id = 1 AND name = '" + EditAFServiceName + "' AND label = '" + EditLabelAFServiceName + "';", 1);
        }

        [Then(@"Se registra el campo adicional de servicio modificado en la tabla AFW_ADDiTIONAL_FIELDS con nuevo orden")]
        public void ThenSeRegistraElCampoAdicionalDeServicioModificadoEnLaTablaAFW_ADDiTIONAL_FIELDSConNuevoOrden()
        {
            int NewOrder = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT [order] FROM AFW_ADDITIONAL_FIELD WHERE label = '" + Label + "';", 1));
            Assert.AreNotEqual(OrderField, NewOrder);
        }

        [When(@"Diligencio etiqueta de campo adicional de servicio")]
        public void WhenDiligencioEtiquetaDeCampoAdicionalDeServicio()
        {
            LabelAFServiceName = DefaultAFServiceName + Functions.RandomText(4);
            CommonElementsAction.SendKeys_InputText("XPath", AFServicesPage.AFServicesInputLabel, LabelAFServiceName);
        }

        [When(@"Diligencio nombre de campo adicional de servicio")]
        public void WhenDiligencioNombreDeCampoAdicionalDeServicio()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input", AFServiceName);
            AFServiceName = CommonElementsAction.VallueExtract("XPath", "//div[2]/div/div/div/div/div[2]/div[2]/input");
        }

        [When(@"Diligencio texto de ayuda de campo adicional de servicio")]
        public void WhenDiligencioTextoDeAyudaDeCampoAdicionalDeServicio()
        {
            CommonElementsAction.SendKeys_InputText("XPath", "//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div/div[2]/div/textarea", "Descriptontext help message");
        }

        [When(@"Diligencio y confirmo las opciones de listado de servicio")]
        public void WhenDiligencioYConfirmoLasOpcionesDeListadoDeServicio()
        {
            Thread.Sleep(3000);
            IList<IWebElement> ListField = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li"));

            Random rdn = new Random();
            CountOptions = rdn.Next(3, 10);

            for (int i = 1; i <= CountOptions; i++)
            {
                try
                {
                    CommonHooks.driver.FindElement(By.XPath("//*[@id='addtional-fields-service']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/input"));

                    UtilAction.SendKeys("//*[@id='addtional-fields-service']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/input", "OptionUI" + i.ToString());
                    Thread.Sleep(1000);
                    UtilAction.Click("//*[@id='addtional-fields-service']/div/div[2]/ul/li[" + ListField.Count + "]/form/div[2]/div[2]/div[2]/div[1]/button");
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                }
            }
        }

        [When(@"Doy click en Aceptar campo adicional de servicio")]
        public void WhenDoyClickEnAceptarCampoAdicionalDeServicio()
        {
            CommonElementsAction.Click("CssSelector", AFServicesPage.AFServicesAccept);
        }

        [When(@"Doy click en Aceptar de mensaje de confirmación de campo adicional de servicio")]
        public void WhenDoyClickEnAceptarDeMensajeDeConfirmacionDeCampoAdicionalDeServicio()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Doy click en editar el campo adicional de servicio de tipo simple")]
        public void WhenDoyClickEnEditarElCampoAdicionalDeServicioDeTipoSimple()
        {
            Thread.Sleep(3000);
            LabelAFServiceName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND name = '" + AFServiceName + "';", 1);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonEdit = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == LabelAFServiceName)
                {
                    IndexButtonEdit = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0, IndexButtonEdit);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + LabelAFServiceName);
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        [When(@"Doy click en eliminar el campo adicional de servicio de tipo simple")]
        public void WhenDoyClickEnEliminarElCampoAdicionalDeServicioDeTipoSimple()
        {
            Thread.Sleep(3000);
            LabelAFServiceName = CommonQuery.DBSelectAValue("SELECT label FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 AND name = '" + AFServiceName + "';", 1);

            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonDelete = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == LabelAFServiceName)
                {
                    IndexButtonDelete = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0, IndexButtonDelete);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + LabelAFServiceName);
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonDelete + "]/div/div/button[@class='delete-button secondary_bg js-delete-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
        }

        [When(@"Doy click en Guardar campo adicional de servicio")]
        public void WhenDoyClickEnGuardarCampoAdicionalDeServicio()
        {
            CommonElementsAction.Click("XPath", AFServicesPage.AFServicesSubmit);
        }

        [When(@"Doy click en Nuevo campo adicional de servicio")]
        public void WhenDoyClickEnNuevoCampoAdicionalDeServicio()
        {
            CommonElementsAction.Click("CssSelector", AFServicesPage.AFServicesButtonNew);
        }

        [When(@"Doy click en opciones avanzadas de campo adicional de servicio")]
        public void WhenDoyClickEnOpcionesAvanzadasDeCampoAdicionalDeServicio()
        {
            CommonElementsAction.Click("XPath", "//div[@id='addtional-fields-service']/div[1]/div[2]/ul/li/form/div[2]/div[3]/div[1]");
        }

        [When(@"Edito nombre de etiqueta de campo adicional de servicio de tipo simple")]
        public void WhenEditoNombreDeEtiquetaDeCampoAdicionalDeServicioDeTipoSimple()
        {
            EditLabelAFServiceName = EditLabelAFServiceName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", AFServicesPage.AFServicesInputLabel, EditLabelAFServiceName);
        }

        [When(@"Eliminación exitosa de campos adicionales servicios")]
        public void WhenEliminacionExitosaDeCamposAdicionalesServicios()
        {
            // CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AFServicesOption,AFServicesPage.AFServicesModulePath);

            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonDelete = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == "Campo prueba 1")
                {
                    IndexButtonDelete = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0, IndexButtonDelete);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + "Campo prueba 1");
            }
            ///     Selecciono el botón eliminar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonDelete + "]/div/div/button[@class='delete-button secondary_bg js-delete-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            ///     pulso Si

            CommonElementsAction.Click("CssSelector", AFServicesPage.AFServicesYes);

            ///     pulso guardar
            CommonElementsAction.Click("XPath", AFServicesPage.AFServicesSubmit);

            //Validate response.
            // CommonAFLS.CommonAflsValidateMessages.ValidateMessageComponent(PageMessages.SuccessElementConfigurationDelete);
            //End Validate response.
        }

        [When(@"Modificación exitosa de campos adicionales servicios")]
        public void WhenModificacionExitosaDeCamposAdicionalesServicios()
        {
            //CommonAFLS.CommonItemMenu.Configuration(SectionTopHeader.EItemConfiguration,SectionAdminLeftColumn.ConfigurationMenu,SectionAdminLeftColumn.AFServicesOption,AFServicesPage.AFServicesModulePath);

            Thread.Sleep(3000);
            IList<IWebElement> all = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li/div/div[2]/div/label"));
            Thread.Sleep(3000);
            String[] allText = new String[all.Count];
            int IndexButtonEdit = 0;
            for (int count = 0; count < all.Count; count++)
            {
                string Locat = all[count].Text;
                if (Locat == "Cantidad de empleados")
                {
                    IndexButtonEdit = count + 1;
                }
            }
            try
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreNotEqual(0, IndexButtonEdit);
            }
            catch
            {
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail("Not found: " + "Cantidad de empleados");
            }
            ///     Selecciono el botón editar
            CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']/div/div[2]/ul/li[" + IndexButtonEdit + "]/div/div/button[@class='edit-button secondary_bg js-edit-button']")).Click();
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)CommonHooks.driver;
            js.ExecuteScript("window.scrollBy(0,1000)");

            ///     modifco nombre
            Console.WriteLine("Navigate from Principal tab." + "\n");
            Thread.Sleep(3000);

            CommonElementsAction.ClearAndSendKeys_InputText("XPath", AFServicesPage.AFServicesInputLabel, "Cantidad de empleados Update");

            Console.WriteLine("\n" + "End Navigate from Principal tab.");

            CommonElementsAction.Click("CssSelector", AFServicesPage.AFServicesAccept);

            ///     pulso guardar
            CommonElementsAction.Click("XPath", AFServicesPage.AFServicesSubmit);
        }

        [When(@"Modifico etiqueta de campo adicional de servicio de tipo simple")]
        public void WhenModificoEtiquetaDeCampoAdicionalDeServicioDeTipoSimple()
        {
            EditLabelAFServiceName = EditLabelAFServiceName + Functions.RandomText(3);
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", AFServicesPage.AFServicesInputLabel, EditLabelAFServiceName);
        }

        [When(@"Modifico nombre de campo adicional de servicio de tipo simple")]
        public void WhenModificoNombreDeCampoAdicionalDeServicioDeTipoSimple()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono el campo adicional de servicio y modifico su orden mediante drag and drop")]
        public void WhenSeleccionoElCampoAdicionalDeServicioYModificoSuOrdenMedianteDragAndDrop()
        {
            Thread.Sleep(5000);
            CommonElementsAction.WaitElement("//div[@id='addtional-fields-service']//ul/li//div[@class='drag-button']", "XPath");

            int CountField = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT COUNT(*) FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002;", 1));
            OrderField = Convert.ToInt32(CommonQuery.DBSelectAValue("SELECT TOP 1 [order] FROM AFW_ADDITIONAL_FIELD AF JOIN AFW_ADDITIONAL_FIELD_DEFINTION AFD ON AF.definition_id = AFD.id WHERE AFD.concept_id = 34002 and [order] <> " + CountField + " ORDER BY NEWID();", 1));

            int count = 0;

            IList<IWebElement> AddFieldList = CommonHooks.driver.FindElements(By.XPath("//div[@id='addtional-fields-service']//ul/li//div[@class='drag-button']"));

            foreach (IWebElement Field in AddFieldList)
            {
                count++;
                if (count == OrderField)
                {
                    Actions Act = new Actions(CommonHooks.driver);
                    Label = CommonHooks.driver.FindElement(By.XPath("//div[@id='addtional-fields-service']//ul/li[" + OrderField + "]//label[@class='additional-field-label primary_color']")).Text;

                    Act.MoveToElement(AddFieldList[OrderField]).DragAndDropToOffset(Field, 0, 180).Build().Perform();
                    Thread.Sleep(3000);
                }
            }
        }

        [When(@"Selecciono la opción Campos adicionales de servicios")]
        public void WhenSeleccionoLaOpcionCamposAdicionalesDeServicios()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono la opción Campos adicionales servicios")]
        public void WhenSeleccionoLaOpcionCamposAdicionalesServicios()
        {
            CommonElementsAction.Click("XPath", AFServicesPage.AFServicesModulePath);
            CommonElementsAction.Click("XPath", Menu.AFServicesOption);
        }

        [When(@"Selecciono tipo de campo adicional de servicio fecha")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeServicioFecha()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "3");
        }

        [When(@"Selecciono tipo de campo adicional de servicio listado")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeServicioListado()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "4");
        }

        [When(@"Selecciono tipo de campo adicional de servicio numérico")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeServicioNumerico()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "2");
        }

        [When(@"Selecciono tipo de campo adicional de servicio párrafo")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeServicioParrafo()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "5");
        }

        [When(@"Selecciono tipo de campo adicional de servicio simple")]
        public void WhenSeleccionoTipoDeCampoAdicionalDeServicioSimple()
        {
            UtilAction.SelectByValue("//div[@id='addtional-fields-service']/div/div[2]/ul/li/form/div[2]/div[2]/div/div/select", "1");
        }
    }
}