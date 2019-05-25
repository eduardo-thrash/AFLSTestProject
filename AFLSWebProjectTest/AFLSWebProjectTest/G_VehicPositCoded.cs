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


    [DeploymentItem("License_12001.lic")]
    public class G_VehicPositCoded : WebTest
    {

        public G_VehicPositCoded()
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

            WebTestRequest request3 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "VehicleTypes/Create")));
            request3.ThinkTime = 17;
            request3.Method = "POST";
            request3.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request3Body = new StringHttpBody();
            request3Body.ContentType = "application/json";
            request3Body.InsertByteOrderMark = false;
            request3Body.BodyString = "{\r\n  \"Name\": \"Automovil WT\",\r\n  \"Description\": \"desc\",\r\n  \"InitialCost\": \"\",\r\n  \"" +
                "CostByKilometer\": \"\",\r\n  \"TransportMode\": \"Car\",\r\n  \"IsActive\": true,\r\n  \"select" +
                "ed\": true,\r\n  \"TransitModes\": null\r\n}";
            request3.Body = request3Body;
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "VehicleTypes/Create")));
            request4.ThinkTime = 17;
            request4.Method = "POST";
            request4.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request4Body = new StringHttpBody();
            request4Body.ContentType = "application/json";
            request4Body.InsertByteOrderMark = false;
            request4Body.BodyString = "{\r\n  \"Name\": \"Moto WT\",\r\n  \"Description\": \"desc\",\r\n  \"InitialCost\": \"\",\r\n  \"CostB" +
                "yKilometer\": \"\",\r\n  \"TransportMode\": \"Car\",\r\n  \"IsActive\": true,\r\n  \"selected\": " +
                "true,\r\n  \"TransitModes\": null\r\n}";
            request4.Body = request4Body;
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "VehicleTypes/Create")));
            request5.ThinkTime = 17;
            request5.Method = "POST";
            request5.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request5Body = new StringHttpBody();
            request5Body.ContentType = "application/json";
            request5Body.InsertByteOrderMark = false;
            request5Body.BodyString = "{\r\n  \"Name\": \"Bus WT\",\r\n  \"Description\": \"desc\",\r\n  \"InitialCost\": \"\",\r\n  \"CostBy" +
                "Kilometer\": \"\",\r\n  \"TransportMode\": \"Car\",\r\n  \"IsActive\": true,\r\n  \"selected\": t" +
                "rue,\r\n  \"TransitModes\": null\r\n}";
            request5.Body = request5Body;
            yield return request5;
            request5 = null;

            WebTestRequest request6 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "VehicleTypes/Create")));
            request6.ThinkTime = 17;
            request6.Method = "POST";
            request6.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request6.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request6Body = new StringHttpBody();
            request6Body.ContentType = "application/json";
            request6Body.InsertByteOrderMark = false;
            request6Body.BodyString = "{\r\n  \"Name\": \"Bicicleta WT\",\r\n  \"Description\": \"desc\",\r\n  \"InitialCost\": \"\",\r\n  \"" +
                "CostByKilometer\": \"\",\r\n  \"TransportMode\": \"Car\",\r\n  \"IsActive\": true,\r\n  \"select" +
                "ed\": true,\r\n  \"TransitModes\": null\r\n}";
            request6.Body = request6Body;
            yield return request6;
            request6 = null;

            WebTestRequest request7 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "WorkPositions/Save")));
            request7.ThinkTime = 11;
            request7.Method = "POST";
            request7.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request7.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request7.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request7Body = new StringHttpBody();
            request7Body.ContentType = "application/json";
            request7Body.InsertByteOrderMark = false;
            request7Body.BodyString = "{\r\n  \"Name\": \"Tecnico WT\",\r\n  \"Cost\": 3499,\r\n  \"IsActive\": true,\r\n  \"selected\": t" +
                "rue\r\n}";
            request7.Body = request7Body;
            yield return request7;
            request7 = null;

            WebTestRequest request8 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "WorkPositions/Save")));
            request8.ThinkTime = 11;
            request8.Method = "POST";
            request8.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request8.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request8.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request8Body = new StringHttpBody();
            request8Body.ContentType = "application/json";
            request8Body.InsertByteOrderMark = false;
            request8Body.BodyString = "{\r\n  \"Name\": \"Instalador WT\",\r\n  \"Cost\": 3499,\r\n  \"IsActive\": true,\r\n  \"selected\"" +
                ": true\r\n}";
            request8.Body = request8Body;
            yield return request8;
            request8 = null;

            WebTestRequest request9 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "WorkPositions/Save")));
            request9.ThinkTime = 11;
            request9.Method = "POST";
            request9.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request9.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request9.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request9Body = new StringHttpBody();
            request9Body.ContentType = "application/json";
            request9Body.InsertByteOrderMark = false;
            request9Body.BodyString = "{\r\n  \"Name\": \"Analista WT\",\r\n  \"Cost\": 3499,\r\n  \"IsActive\": true,\r\n  \"selected\": " +
                "true\r\n}";
            request9.Body = request9Body;
            yield return request9;
            request9 = null;

            WebTestRequest request10 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "WorkPositions/Save")));
            request10.ThinkTime = 11;
            request10.Method = "POST";
            request10.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request10.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request10.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request10Body = new StringHttpBody();
            request10Body.ContentType = "application/json";
            request10Body.InsertByteOrderMark = false;
            request10Body.BodyString = "{\r\n  \"Name\": \"Desarrollador WT\",\r\n  \"Cost\": 3499,\r\n  \"IsActive\": true,\r\n  \"select" +
                "ed\": true\r\n}";
            request10.Body = request10Body;
            yield return request10;
            request10 = null;

            WebTestRequest request11 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "WorkPositions/Save")));
            request11.ThinkTime = 11;
            request11.Method = "POST";
            request11.Headers.Add(new WebTestRequestHeader("Accept", "application/json, text/javascript, */*; q=0.01"));
            request11.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request11.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            StringHttpBody request11Body = new StringHttpBody();
            request11Body.ContentType = "application/json";
            request11Body.InsertByteOrderMark = false;
            request11Body.BodyString = "{\r\n  \"Name\": \"Gerente Delete WT\",\r\n  \"Cost\": 3499,\r\n  \"IsActive\": true,\r\n  \"selec" +
                "ted\": true\r\n}";
            request11.Body = request11Body;
            yield return request11;
            request11 = null;
        }
    }
}
