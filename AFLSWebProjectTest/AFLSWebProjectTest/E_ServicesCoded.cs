﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AFLSWebProjectTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;


    [DeploymentItem("aflswebprojecttest\\ServiceData.csv", "aflswebprojecttest")]
    [DataSource("ServicesSource", "Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\aflswebprojecttest\\ServiceData.csv", Microsoft.VisualStudio.TestTools.WebTesting.DataBindingAccessMethod.Sequential, Microsoft.VisualStudio.TestTools.WebTesting.DataBindingSelectColumns.SelectOnlyBoundColumns, "ServiceData#csv")]
    public class E_ServicesCoded : WebTest
    {

        public E_ServicesCoded()
        {
            this.Context.Add("Url", "http://localhost");
            this.Context.Add("Instance", "/AFLS/");
            this.PreAuthenticate = true;
            this.Proxy = "default";
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            // Inicializar reglas de validación aplicables a todas las solicitudes de prueba web
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidateResponseUrl validationRule1 = new ValidateResponseUrl();
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidationRuleResponseTimeGoal validationRule2 = new ValidationRuleResponseTimeGoal();
                validationRule2.Tolerance = 0D;
                this.ValidateResponseOnPageComplete += new EventHandler<ValidationEventArgs>(validationRule2.Validate);
            }

            WebTestRequest request1 = new WebTestRequest((this.Context["Url"].ToString() + this.Context["Instance"].ToString()));
            request1.ThinkTime = 1;
            request1.ExpectedResponseUrl = (this.Context["Url"].ToString()
                        + (this.Context["Instance"].ToString() + "LogOn"));
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "Account/LogOn")));
            request2.Method = "POST";
            request2.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request2.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString()
                                + (this.Context["Instance"].ToString() + "LogOn"))));
            StringHttpBody request2Body = new StringHttpBody();
            request2Body.ContentType = "application/json";
            request2Body.InsertByteOrderMark = false;
            request2Body.BodyString = "{\"DefaultAuth\":\"ARANDA\",\"UserName\":\"administrator\",\"Password\":\"ABC123\",\"RememberM" +
                "e\":\"true\"}";
            request2.Body = request2Body;
            yield return request2;
            request2 = null;

            CountingLoopRule conditionalRule1 = new CountingLoopRule();
            conditionalRule1.ContextParameterName = "Contador de bucle";
            conditionalRule1.IterationsCount = 261D;

            int maxIterations1 = -1;
            bool advanceDataCursors1 = true;
            this.BeginLoop(conditionalRule1, maxIterations1, advanceDataCursors1);
            this.RegisterDataSourceInLoop(conditionalRule1, "ServicesSource", "ServiceData#csv");

            for (; this.ExecuteConditionalRule(conditionalRule1);)
            {
                WebTestRequest request3 = new WebTestRequest((this.Context["Url"].ToString()
                                + (this.Context["Instance"].ToString() + "Services/Save")));
                request3.Method = "POST";
                request3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
                request3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
                request3.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
                StringHttpBody request3Body = new StringHttpBody();
                request3Body.ContentType = "application/json";
                request3Body.InsertByteOrderMark = false;
                request3Body.BodyString = ("{\r\n  \"BaseCost\": 12400,\r\n  \"Description\": \""
                            + (this.Context["ServicesSource.ServiceData#csv.Description"].ToString()
                            + ("\",\r\n  \"Name\": \""
                            + (this.Context["ServicesSource.ServiceData#csv.Name"].ToString()
                            + ("\",\r\n  \"ExecutionTime\": \"\",\r\n  \"IsActive\": true,\r\n  \"selected\": true,\r\n  \"InvCost\"" +
                                ": 0,\r\n  \"ModelId\": 1,\r\n  \"CalendarId\": 1,\r\n  \"SlaId\": "
                            + (this.Context["ServicesSource.ServiceData#csv.SLA"].ToString()
                            + (",\r\n  \"UcId\": "
                            + (this.Context["ServicesSource.ServiceData#csv.UC"].ToString()
                            + (",\r\n  \"OlaId\": "
                            + (this.Context["ServicesSource.ServiceData#csv.OLA"].ToString()
                            + (",\r\n  \"Type\": "
                            + (this.Context["ServicesSource.ServiceData#csv.ServiceType"].ToString()
                            + (",\r\n  \"ProviderAssignmentType\": \""
                            + (this.Context["ServicesSource.ServiceData#csv.AssignmentType"].ToString()
                            + ("\",\r\n  \"Model\": 1,\r\n  \"SubjectDefault\": \""
                            + (this.Context["ServicesSource.ServiceData#csv.Subject"].ToString()
                            + ("\",\r\n  \"Calendar\": 1,\r\n  \"Sla\": "
                            + (this.Context["ServicesSource.ServiceData#csv.SLA"].ToString()
                            + (",\r\n  \"Uc\": "
                            + (this.Context["ServicesSource.ServiceData#csv.UC"].ToString()
                            + (",\r\n  \"Ola\": "
                            + (this.Context["ServicesSource.ServiceData#csv.OLA"].ToString()
                            + (",\r\n  \"ServiceType\": \""
                            + (this.Context["ServicesSource.ServiceData#csv.ServiceType"].ToString() + @""",
  ""ser_hours"": ""0"",
  ""ser_mins"": ""30"",
  ""IsDefault"": true,
  ""IsPriorityOrEmergency"": false,
  ""IsProvideAllCIs"": false,
  ""TimePlanning"": 30,
  ""Skills"": [
    {
      ""Description"": ""desc"",
      ""Id"": 1,
      ""IsActive"": true,
      ""Name"": ""Habilidad"",
      ""QuatityAssociatedGroups"": 0,
      ""QuatityAssociatedServices"": 0,
      ""QuatityAssociatedSpecialists"": 0,
      ""label"": ""Habilidad"",
      ""value"": ""Habilidad"",
      ""IsRequired"": false,
      ""Weight"": 2
    }
  ],
  ""ServiceProducts"": [],
  ""ProviderServices"": [],
  ""ServiceTasks"": [],
  ""AdditionalFields"": []
}"))))))))))))))))))))))));
                request3.Body = request3Body;
                yield return request3;
                request3 = null;
            }

            this.EndLoop(conditionalRule1);
        }
    }
}