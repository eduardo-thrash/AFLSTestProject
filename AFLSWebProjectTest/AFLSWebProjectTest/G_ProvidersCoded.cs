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


    [DeploymentItem("aflswebprojecttest\\ProvidersData.csv", "aflswebprojecttest")]
    [DataSource("ProvidersSource", "Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\aflswebprojecttest\\ProvidersData.csv", Microsoft.VisualStudio.TestTools.WebTesting.DataBindingAccessMethod.Sequential, Microsoft.VisualStudio.TestTools.WebTesting.DataBindingSelectColumns.SelectOnlyBoundColumns, "ProvidersData#csv")]
    public class G_ProvidersCoded : WebTest
    {

        public G_ProvidersCoded()
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
            conditionalRule1.IterationsCount = 34D;

            int maxIterations1 = -1;
            bool advanceDataCursors1 = true;
            this.BeginLoop(conditionalRule1, maxIterations1, advanceDataCursors1);
            this.RegisterDataSourceInLoop(conditionalRule1, "ProvidersSource", "ProvidersData#csv");

            for (; this.ExecuteConditionalRule(conditionalRule1);)
            {
                WebTestRequest request3 = new WebTestRequest((this.Context["Url"].ToString()
                                + (this.Context["Instance"].ToString() + "Providers/Create")));
                request3.ThinkTime = 1;
                request3.Method = "POST";
                request3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
                request3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
                request3.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
                StringHttpBody request3Body = new StringHttpBody();
                request3Body.ContentType = "application/json";
                request3Body.InsertByteOrderMark = false;
                request3Body.BodyString = ("{\r\n  \"Name\": \""
                            + (this.Context["ProvidersSource.ProvidersData#csv.Name"].ToString()
                            + ("\",\r\n  \"MonitorGroups\": [],\r\n  \"Monitors\": [],\r\n  \"Services\": [],\r\n  \"Specialist\":" +
                                " [],\r\n  \"Zones\": [],\r\n  \"IsActive\": "
                            + (this.Context["ProvidersSource.ProvidersData#csv.IsActive"].ToString()
                            + (",\r\n  \"AssignType\": "
                            + (this.Context["ProvidersSource.ProvidersData#csv.AssignType"].ToString()
                            + (",\r\n  \"IsExternal\": "
                            + (this.Context["ProvidersSource.ProvidersData#csv.IsExternal"].ToString()
                            + (",\r\n  \"ServiceDefault\": "
                            + (this.Context["ProvidersSource.ProvidersData#csv.ServiceDefault"].ToString()
                            + (",\r\n  \"Priority\": \""
                            + (this.Context["ProvidersSource.ProvidersData#csv.Priority"].ToString()
                            + ("\",\r\n  \"Score\": {\r\n    \"Qualification\": 10,\r\n    \"Accomplishment\": 10,\r\n    \"Reply" +
                                "\": 10\r\n  },\r\n  \"selected\": true,\r\n  \"Description\": \""
                            + (this.Context["ProvidersSource.ProvidersData#csv.Name"].ToString()
                            + ("\",\r\n  \"providerType\": \""
                            + (this.Context["ProvidersSource.ProvidersData#csv.Description"].ToString()
                            + ("\",\r\n  \"isManual\": \""
                            + (this.Context["ProvidersSource.ProvidersData#csv.isManual"].ToString() + "\"\r\n}"))))))))))))))))));
                request3.Body = request3Body;
                yield return request3;
                request3 = null;
            }

            this.EndLoop(conditionalRule1);
        }
    }
}
