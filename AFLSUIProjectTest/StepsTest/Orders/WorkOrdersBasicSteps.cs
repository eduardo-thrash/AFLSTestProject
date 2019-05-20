﻿using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.StepsTest.AFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.AFLS;
using AFLSUIProjectTest.UIMap.Messages;
using AFLSUIProjectTest.UIMap.Orders;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.Orders
{
    [Binding]
    public class WorkOrdersBasicSteps
    {
        private readonly PageMessages PageMessages = new PageMessages();

        private LoginLogoutSteps LoginLogoutSteps = new LoginLogoutSteps();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private PrincipalMenuPage PrincipalMenuPage = new PrincipalMenuPage();
        private ResponseValidation ResponseValidation = new ResponseValidation();
        private MessagesElements MessagesElements = new MessagesElements();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();
        private MessagesCopies MessagesCopies = new MessagesCopies();
        private WorkordersPage WorkordersPage = new WorkordersPage();

        private string ClientName;
        private string UserDispatcher;
        private string ServiceName;
        private int TicketId;
        private int AdditionalFieldFound = 0;

        [Given(@"Tengo un usuario con rol despachador")]
        public void GivenTengoUnUsuarioConRolDespachador()
        {
            UserDispatcher = CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = 'thrash'", 1);
        }

        [Given(@"Existe un cliente sin email, teléfono y compañía asociada")]
        public void GivenExisteUnClienteSinEmailTelefonoYCompaniaAsociada()
        {
            ClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_name FROM AFLS_USERS_CLIENTS CLI JOIN AFW_USERS URS ON CLI.user_id = URS.user_id WHERE URS.user_active = 1 AND urs.user_phone1 IS NULL AND URS.user_email IS NULL AND  CLI.comp_id IS NULL ORDER BY NEWID()", 1);
        }

        [Given(@"Existe un cliente")]
        public void GivenExisteUnCliente()
        {
            ClientName = CommonQuery.DBSelectAValue("SELECT TOP 1 URS.user_name FROM AFLS_USERS_CLIENTS CLI JOIN AFW_USERS URS ON CLI.user_id = URS.user_id WHERE URS.user_active = 1 ORDER BY NEWID()", 1);
        }

        [Given(@"Existen servicios asociados al cliente")]
        public void GivenExistenServiciosAsociadosAlCliente()
        {
            try
            {
                ServiceName = CommonQuery.DBSelectAValue("SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 ORDER BY NEWID();", 1);
                int RemoveCar = ServiceName.Length - 10;
                ServiceName = ServiceName.Remove(10, RemoveCar);
            }
            catch
            {
                Assert.Fail("Error en consulta SELECT TOP 1 serv_name FROM AFLS_SERVICES WHERE serv_default = 1 ORDER BY NEWID();");
            }
        }

        [When(@"Accedo a ítem Nueva orden")]
        public void WhenAccedoAItemNuevaOrden()
        {
            CommonElementsAction.Click("XPath", PrincipalMenuPage.ItemNewOrder);
            Thread.Sleep(5000);
        }

        [When(@"Diligencio y selecciono un cliente de orden")]
        public void WhenDiligencioYSeleccionoUnClienteDeOrden()
        {
            Thread.Sleep(2000);
            CommonElementsAction.Select_ComboboxAutocomplete("XPath", WorkordersPage.ClientName, ClientName, "a");
        }

        [When(@"Diligencio Dirección de cita de orden")]
        public void WhenDiligencioDireccionDeCitaDeOrden()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("XPath", WorkordersPage.Address, "calle 64 # 5-22 Bogota Colombia");
            Thread.Sleep(2000);
        }

        [When(@"Diligencio campo de solicitante de cita de orden")]
        public void WhenDiligencioCampoDeSolicitanteDeCitaDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.ContactName, "Rubiela Quintero");
        }

        [When(@"Diligencio Teléfono de Solicitante de orden")]
        public void WhenDiligencioTelefonoDeSolicitanteDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.ContactPhone, "3005869685");
        }

        [When(@"Diligencio Correo de Solicitante de orden")]
        public void WhenDiligencioCorreoDeSolicitanteDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.ContactEmail, "jose.montenegro@arandasoft.com");
        }

        [When(@"Diligencio Detalle de la dirección de cita de orden")]
        public void WhenDiligencioDetalleDeLaDireccionDeCitaDeOrden()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("XPath", WorkordersPage.AddlAddressInfo, "Apartamento 708");
        }

        [When(@"Diligencio y selecciono servicio de orden")]
        public void WhenDiligencioYSeleccionoServicioDeOrden()
        {
            UtilAction.Select_ComboboxAutocomplete(WorkordersPage.ServiceName, ServiceName, "a");
            Thread.Sleep(2000);
        }

        [When(@"Selecciono Tipo de Orden Normal de orden")]
        public void WhenSeleccionoTipoDeOrdenNormalDeOrden()
        {
            CommonElementsAction.Click("XPath", WorkordersPage.OptionOrderNormal);
            Thread.Sleep(2000);
        }

        [When(@"Diligencio Asunto de orden")]
        public void WhenDiligencioAsuntoDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.Subject, "Asunto orden de trabajo UI");
        }

        [When(@"Diligencio descripción de orden")]
        public void WhenDiligencioDescripcionDeOrden()
        {
            CommonElementsAction.ClearAndSendKeys_InputText("XPath", WorkordersPage.Description, "Descripción orden de trabajo UI Lorem ipsum dolor sit amet, consectetur adipiscing elit.Vestibulum massa elit, rutrum quis lacinia nec, eleifend eget diam.Vestibulum ante arcu, consequat at lacus sed, sollicitudin vulputate elit.");
        }

        [When(@"Selecciono el Tab de campos adicionales de orden de trabajo")]
        public void WhenSeleccionoElTabDeCamposAdicionalesDeOrdenDeTrabajo()
        {
            try
            {
                UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-9']");
            }
            catch
            {
                Thread.Sleep(2000);

                UtilAction.Click("//div[@class='workOrder contentWO']//a[@class='jcarousel-control-next']");
                UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-9']");
            }
        }

        [When(@"Diligencio campos adicionales de orden de trabajo")]
        public int WhenDiligencioCamposAdicionalesDeOrdenDeTrabajo()
        {
            try
            {
                IList<IWebElement> AFClientsListInputText = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@type='text']"));
                foreach (IWebElement AFClient in AFClientsListInputText)
                {
                    AFClient.Clear();
                    AFClient.SendKeys(Functions.RandomText(10));
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }
                IList<IWebElement> AFClientsListTextarea = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//textarea"));
                foreach (IWebElement AFClient in AFClientsListTextarea)
                {
                    AFClient.Clear();
                    AFClient.SendKeys("Texto parrafo");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListNumber = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//input[@type='number']"));
                foreach (IWebElement AFClient in AFClientsListNumber)
                {
                    AFClient.Clear();
                    AFClient.SendKeys("123456");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListDate = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//span[@class='k-icon k-i-calendar']"));
                foreach (IWebElement AFClient in AFClientsListDate)
                {
                    AFClient.Click();
                    CommonElementsAction.Click("XPath", "//div[@class='k-widget k-calendar']/table/tbody/tr/td/a");
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }

                IList<IWebElement> AFClientsListSelect = CommonHooks.driver.FindElements(By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-9']//div[@class='listAdditionalFields']//div[@class='additionalFieldContainer']//select"));
                foreach (IWebElement AFClient in AFClientsListSelect)
                {
                    new SelectElement(AFClient).SelectByIndex(1);
                    Thread.Sleep(1000);
                    AdditionalFieldFound++;
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

            return AdditionalFieldFound;
        }

        [When(@"Doy click en Crear orden")]
        public void WhenDoyClickEnCrearOrden()
        {
            CommonElementsAction.Click("XPath", WorkordersPage.Save);
        }

        [Then(@"Se registra en la tabla AFLS_WORKORDERS la orden con ticket_id, longitud, latitud y dirección")]
        public void ThenSeRegistraEnLaTablaAFLS_WORKORDERSLaOrdenConTicket_IdLongitudLatitudYDireccion()
        {
            CommonQuery.DBSelectAValue("SELECT * FROM AFLS_WORKORDERS WHERE ticket_id = " + TicketId + " AND work_longitude IS NOT NULL AND work_latitude IS NOT NULL AND work_address IS NOT NULL;", 1);
        }

        [Then(@"se muestra mensaje indicando que se creo la orden de trabajo correctamente")]
        public void ThenSeMuestraMensajeIndicandoQueSeCreoLaOrdenDeTrabajoCorrectamente()
        {
            TicketId = Convert.ToInt32(ResponseValidation.ValidateSuccessOrdernCreate());
        }

        [When(@"Diligencio Dirección de cita de orden dando click en cursor")]
        public void WhenDiligencioDireccionDeCitaDeOrdenDandoClickEnCursor()
        {
            CommonElementsAction.SendKeys_InputText("XPath", WorkordersPage.Address, "calle 64 # 5-22 Bogota Colombia");
            Thread.Sleep(2000);
            CommonElementsAction.Click("XPath", "//div[@class='workOrder contentWO']//input[@id='clientAddresCheck']");
        }

        [When(@"Diligencio Dirección de cita de orden dando enter")]
        public void WhenDiligencioDireccionDeCitaDeOrdenDandoEnter()
        {
            CommonElementsAction.EnterAfterSendKeys_InputText("XPath", WorkordersPage.Address, "calle 64 # 5-22 Bogota Colombia");
        }

        [When(@"Diligencio Dirección de cita de orden dando tab")]
        public void WhenDiligencioDireccionDeCitaDeOrdenDandoTab()
        {
            CommonElementsAction.SendKeys_InputText("XPath", WorkordersPage.Address, "calle 64 # 5-22 Bogota Colombia");
            Thread.Sleep(2000);
            CommonHooks.driver.FindElement(By.XPath(WorkordersPage.Address)).SendKeys(Keys.Tab);
        }

        [When(@"Diligencio Dirección de cita de orden dando click en mapa")]
        public void WhenDiligencioDireccionDeCitaDeOrdenDandoClickEnMapa()
        {
            try
            {
                UtilAction.Click("//div[@class='workOrder contentWO']//div[@class='woMapOrder ui maps']");
            }
            catch
            {
            }
        }
    }
}