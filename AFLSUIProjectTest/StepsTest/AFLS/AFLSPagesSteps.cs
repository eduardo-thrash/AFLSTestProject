﻿using AFLSUIProjectTest.CommonAFLS;
using AFLSUIProjectTest.UIMap;
using AFLSUIProjectTest.UIMap.Configuration;
using CommonTest.CommonTest;
using TechTalk.SpecFlow;

namespace AFLSUIProjectTest.StepsTest.AFLS

{
    [Binding]
    public class AFLSPagesSteps
    {
        private SLAsPage SLAsPage = new SLAsPage();
        private ConfigurationMenuPage ConfigurationMenuPage = new ConfigurationMenuPage();
        private Logout Logout = new Logout();
        private AFLSCommonFunctions Functions = new AFLSCommonFunctions();

        [Given(@"Tengo un usuario con rol administrador")]
        public void GivenTengoUnUsuarioConRolAdministrador()
        {
            CommonQuery.DBSelectAValue("SELECT user_nick_name FROM AFW_USERS WHERE user_nick_name = 'administrator';", 1);
        }

        [When(@"Selecciono la opción ANS's")]
        public void WhenSeleccionoLaOpcionANSS()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.SLAOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal ANS's")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalANSS()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción OLA's")]
        public void WhenSeleccionoLaOpcionOLAS()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.OLAOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal OLA's")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalOLAS()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción UC's")]
        public void WhenSeleccionoLaOpcionUCS()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.UCOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal UC's")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalUCS()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Calendarios")]
        public void WhenSeleccionoLaOpcionCalendarios()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.CalendarOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Calendarios")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCalendarios()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Cronometros")]
        public void WhenSeleccionoLaOpcionCronometros()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ChronometerOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Cronometros")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCronometros()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Modelos")]
        public void WhenSeleccionoLaOpcionModelos()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ModelOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Modelos")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalModelos()
        {
            Functions.MissingKeyFind();
        }

        [When(@"selecciono la opción Servicios")]
        public void WhenSeleccionoLaOpcionServicios()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ServiceOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Servicios")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalServicios()
        {
            Functions.MissingKeyFind();
        }

        [When(@"selecciono la opción Relaciones")]
        public void WhenSeleccionoLaOpcionRelaciones()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.RelationOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Relaciones")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalRelaciones()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Comapñias")]
        public void WhenSeleccionoLaOpcionComapnias()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.CompanyOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Comapñias")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalComapnias()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Clientes")]
        public void WhenSeleccionoLaOpcionClientes()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ClientOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Clientes")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalClientes()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Transportes")]
        public void WhenSeleccionoLaOpcionTransportes()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MeansTransportOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Transportes")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalTransportes()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Cargos")]
        public void WhenSeleccionoLaOpcionCargos()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.PositionOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Cargos")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCargos()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono la opción Proveedores")]
        public void WhenSeleccionoLaOpcionProveedores()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ProviderOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Proveedores")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalProveedores()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono la opción Habilidades")]
        public void WhenSeleccionoLaOpcionHabilidades()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.SkillOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Habilidades")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalHabilidades()
        {
            Functions.MissingKeyFind();
        }

        [When(@"selecciono la opción Usuarios Web")]
        public void WhenSeleccionoLaOpcionUsuariosWeb()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.WebUserOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Usuarios Web")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalUsuariosWeb()
        {
            Functions.MissingKeyFind();
        }

        [When(@"selecciono la opción Grupos Webs")]
        public void WhenSeleccionoLaOpcionGruposWebs()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.WebGroupOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Grupos Web")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalGruposWeb()
        {
            Functions.MissingKeyFind();
        }

        [When(@"selecciono la opción Usuarios Movil")]
        public void WhenSeleccionoLaOpcionUsuariosMovil()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MobileUserOption);
        }

        [When(@"selecciono la opción Grupos Movil")]
        public void WhenSeleccionoLaOpcionGruposMovil()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MobileGroupOption);
        }

        [When(@"selecciono la opción Zonas")]
        public void WhenSeleccionoLaOpcionZonas()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ZoneOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Zonas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalZonas()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Accedo al menú Inventario")]
        public void WhenAccedoAlMenuInventario()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.InventoryMenu);
        }

        [When(@"Selecciono la opción Medidas")]
        public void WhenSeleccionoLaOpcionMedidas()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MeasureOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Medidas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalMedidas()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Productos")]
        public void WhenSeleccionoLaOpcionProductos()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ProductOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Productos")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalProductos()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Ubicaciones")]
        public void WhenSeleccionoLaOpcionUbicaciones()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Valido que no existan MissingKey en pantalla principal  Ubicaciones")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalUbicaciones()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Accedo al menú Integración")]
        public void WhenAccedoAlMenuIntegracion()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Selecciono la opción LDAP")]
        public void WhenSeleccionoLaOpcionLDAP()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.LDAPOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal LDAP")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalLDAP()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción ASDK")]
        public void WhenSeleccionoLaOpcionASDK()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ASDKOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal ASDK")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalASDK()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Otras aplicaciones")]
        public void WhenSeleccionoLaOpcionOtrasAplicaciones()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ThirdPartyOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Otras aplicaciones")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalOtrasAplicaciones()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Accedo al menú Configuración")]
        public void WhenAccedoAlMenuConfiguracion()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.ConfigurationMenu);
        }

        [When(@"Selecciono la opción Información basica")]
        public void WhenSeleccionoLaOpcionInformacionBasica()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.EstablishmentOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Información basica")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalInformacionBasica()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Campos adicionales compañías")]
        public void WhenSeleccionoLaOpcionCamposAdicionalesCompanias()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.AFCompaniesOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Campos adicionales compañías")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCamposAdicionalesCompanias()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Campos adicionales clientes")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCamposAdicionalesClientes()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Campos adicionales servicios")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCamposAdicionalesServicios()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Campos adicionales ordenes")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCamposAdicionalesOrdenes()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Días no laborales")]
        public void WhenSeleccionoLaOpcionDiasNoLaborales()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.NonWorkingDaysOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Dias no laborales")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalDiasNoLaborales()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Servidor de correo")]
        public void WhenSeleccionoLaOpcionServidorDeCorreo()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.MailServerOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Servidor de correo")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalServidorDeCorreo()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Encuestas general")]
        public void WhenSeleccionoLaOpcionEncuentasGeneral()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.SurveyGeneralConfigurationOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Encuentas general")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalEncuentasGeneral()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Plantillas de Encuentas")]
        public void WhenSeleccionoLaOpcionPlantillasDeEncuentas()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.SurveyTemplateOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Plantillas de Encuentas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalPlantillasDeEncuentas()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Respuestas rápidas")]
        public void WhenSeleccionoLaOpcionRespuestasrápidas()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.QuickAnswersOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Respuestas rápidas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalRespuestasrápidas()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Plantillas de correo")]
        public void WhenSeleccionoLaOpcionPlantillasDeCorreo()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.GeneralEmailTemplateOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Plantillas de correo")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalPlantillasDeCorreo()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Reglas de asignación")]
        public void WhenSeleccionoLaOpcionReglasDeAsignacion()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.AssigmentRulesOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Reglas de asignación")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalReglasDeAsignacion()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Precisión de ubicación")]
        public void WhenSeleccionoLaOpcionPrecisionDeUbicacion()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.AccuracyOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Precisión de ubicación")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalPrecisionDeUbicacion()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Licenciamiento")]
        public void WhenSeleccionoLaOpcionLicenciamiento()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.LicensingOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Licenciamiento")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalLicenciamiento()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Canal AssistMe")]
        public void WhenSeleccionoLaOpcionCanalAssistMe()
        {
            CommonElementsAction.Click("XPath", ConfigurationMenuPage.AssistMeOption);
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Canal AssistMe")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalCanalAssistMe()
        {
            Functions.MissingKeyFind();
        }

        [When(@"Selecciono la opción Gestión de alertas")]
        public void WhenSeleccionoLaOpcionGestionDeAlertas()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Valido que no existan MissingKey en pantalla principal Gestión de alertas")]
        public void WhenValidoQueNoExistanMissingKeyEnPantallaPrincipalGestionDeAlertas()
        {
            Functions.MissingKeyFind();
        }

        [Then(@"Cierro Sesión en la aplicación")]
        public void ThenCierroSesionEnLaAplicacion()
        {
            Logout.AdministratorLogOff();
        }
    }
}