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


    public class J_LicenseCoded : WebTest
    {

        public J_LicenseCoded()
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
                            + (this.Context["Instance"].ToString() + "License/AssignNamed")));
            request3.Method = "POST";
            request3.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3Body.FormPostParameters.Add("licenseId", "1");
            request3Body.FormPostParameters.Add("userId", "3");
            request3.Body = request3Body;
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "License/AssignNamed")));
            request4.Method = "POST";
            request4.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request4.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            FormPostHttpBody request4Body = new FormPostHttpBody();
            request4Body.FormPostParameters.Add("licenseId", "4");
            request4Body.FormPostParameters.Add("userId", "3");
            request4.Body = request4Body;
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "License/AssignNamed")));
            request5.Method = "POST";
            request5.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request5.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            FormPostHttpBody request5Body = new FormPostHttpBody();
            request5Body.FormPostParameters.Add("licenseId", "5");
            request5Body.FormPostParameters.Add("userId", "3");
            request5.Body = request5Body;
            yield return request5;
            request5 = null;

            WebTestRequest request6 = new WebTestRequest((this.Context["Url"].ToString()
                            + (this.Context["Instance"].ToString() + "License/AssignNamed")));
            request6.Method = "POST";
            request6.Headers.Add(new WebTestRequestHeader("Accept", "*/*"));
            request6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request6.Headers.Add(new WebTestRequestHeader("Referer", (this.Context["Url"].ToString() + this.Context["Instance"].ToString())));
            FormPostHttpBody request6Body = new FormPostHttpBody();
            request6Body.FormPostParameters.Add("licenseId", "1");
            request6Body.FormPostParameters.Add("userId", "8");
            request6.Body = request6Body;
            yield return request6;
            request6 = null;
        }
    }
}