using Ayehu.Sdk.ActivityCreation.Extension;
using Ayehu.Sdk.ActivityCreation.Interfaces;
using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;

namespace Ayehu.Sdk.ActivityCreation
{
    public class CheckPointDeleteAccessRule : IActivity
    {
        #region Private readonly properties

        private readonly string API_REQUEST_URL = "{0}:443/web_api/delete-access-rule";
        private readonly string CONTENT_TYPE = "application/json";
        private readonly string METHOD = "POST";

        #endregion

        #region Incoming properties 

        public string AuthorizationToken;
        public string MgmtServer;

        public string Layer;
        public string Uid;

        #endregion

        #region Public methods

        public ICustomActivityResult Execute()
        {
            var httpWebRequest = HttpRequest();

            HttpWebResponse httpResponse;
            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(IncidentJsonBuilder());
                    streamWriter.Flush();
                    streamWriter.Close();
                    httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var responseString = streamReader.ReadToEnd();
                            var error_messageerrorSummary = (JObject.Parse(responseString)["message"]).Value<string>();

                            return this.GenerateActivityResult(error_messageerrorSummary);
                        }
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                }
            }
            catch (WebException ex)
            {
                using (var streamReader = new StreamReader(ex.Response.GetResponseStream()))
                {
                    var responseString = streamReader.ReadToEnd();
                    var error_messageerrorSummary = (JObject.Parse(responseString)["message"]).Value<string>();
                    throw new Exception(error_messageerrorSummary);
                }
            }
        }

        #endregion

        #region Private methods 

        private WebRequest HttpRequest()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format(API_REQUEST_URL, MgmtServer));
            httpWebRequest.ContentType = CONTENT_TYPE;
            httpWebRequest.Method = METHOD;
            httpWebRequest.Headers.Add("X-chkp-sid", AuthorizationToken);

            return httpWebRequest;
        }

        private IDictionary<string, string> ExposeJson(JObject jObject, string search_till, string append = "")
        {
            var result = new Dictionary<string, string>();

            foreach (var jProperty in jObject.Properties())
            {
                if (append + jProperty.Name == search_till)
                {
                    return result;
                }

                var jToken = jProperty.Value;

                if (jToken.Type == JTokenType.Object)
                {
                    var nested_result = ExposeJson(jToken as JObject, search_till, append + jProperty.Name + "_");

                    if (nested_result == null)
                    {
                        return result;
                    }
                    result = result.Concat(nested_result).ToDictionary(q => q.Key, q => q.Value);
                }
                else if (jToken.Type == JTokenType.Array || jToken.Type == JTokenType.String)
                {
                    result.Add(append + jProperty.Name, jProperty.Value.ToString());
                }
            }

            return result;
        }

        private string IncidentJsonBuilder()
        {
            StringBuilder incidentJson = new StringBuilder();

            incidentJson.Append("{\"layer\": \"");
            incidentJson.Append(Layer);
            incidentJson.Append("\",\"uid\": \"");
            incidentJson.Append(Uid);
            incidentJson.Append("\"}");

            return incidentJson.ToString();
        }

        #endregion
    }


}