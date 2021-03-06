using System;
using Ayehu.Sdk.ActivityCreation.Interfaces;
using Ayehu.Sdk.ActivityCreation.Extension;
using Ayehu.Sdk.ActivityCreation.Helpers;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Collections.Generic;

namespace Ayehu.Sdk.ActivityCreation
{
    public class CustomActivity_AY_IncidentConfigurationUpdateIncidentDevice : IActivityAsync
    {


    
    public string endPoint = "https://{hostname}:8442";
    
    public string Jsonkeypath = "updateDevice";
    
    public string password1 = "";
    
    public string incidentDevice = "";
    
    public string id_p = "";
    
    public string name_p = "";
    
    public string description = "";
    
    public string username = "";
    
    public string password = "";
    
    public string deleted = "";
    
    public string deviceType = "";
    
    public string site = "";
    
    public string executorId = "";
    
    public string ipAddress = "";
    
    public string platform = "";
    
    public string executeWorkflowForEveryUpdate = "";
    
    public string snmpMibs = "";
    
    public string sshCertificate = "";
    
    public string macAddress = "";
    
    public string inheritSSHCertificate = "";
    
    public string ticketID = "";
    
    private bool omitJsonEmptyorNull = true;
    
    private string contentType = "application/json";
    
    private string httpMethod = "PUT";
    
    private string uriBuilderPath {
        get {
            return "Server/API/IncidentConfiguration/updateDevice";
        }
    }
    
    private string postData {
        get {
            return string.Format("{{ \"id\": \"{0}\",  \"name\": \"{1}\",  \"description\": \"{2}\",  \"username\": \"{3}\",  \"password\": \"{4}\",  \"deleted\": \"{5}\",  \"deviceType\": \"{6}\",  \"site\": \"{7}\",  \"executorId\": \"{8}\",  \"ipAddress\": \"{9}\",  \"platform\": \"{10}\",  \"executeWorkflowForEveryUpdate\": \"{11}\",  \"snmpMibs\": \"{12}\",  \"sshCertificate\": \"{13}\",  \"macAddress\": \"{14}\",  \"inheritSSHCertificate\": \"{15}\",  \"ticketID\": \"{16}\" }}",id_p,name_p,description,username,password,deleted,deviceType,site,executorId,ipAddress,platform,executeWorkflowForEveryUpdate,snmpMibs,sshCertificate,macAddress,inheritSSHCertificate,ticketID);
        }
    }
    
    private System.Collections.Generic.Dictionary<string, string> headers {
        get {
            return new Dictionary<string, string>() {{"authorization","Bearer " + password1}};
        }
    }
    
    private System.Collections.Generic.Dictionary<string, string> queryStringArray {
        get {
            return new Dictionary<string, string>() {};
        }
    }


        public async System.Threading.Tasks.Task<ICustomActivityResult> Execute()
        {

            HttpClient client = new HttpClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
            UriBuilder UriBuilder = new UriBuilder(endPoint); 
            UriBuilder.Path = uriBuilderPath;
            UriBuilder.Query = AyehuHelper.queryStringBuilder(queryStringArray);
            HttpRequestMessage myHttpRequestMessage = new HttpRequestMessage(new HttpMethod(httpMethod), UriBuilder.ToString());
           
            if (contentType == "application/x-www-form-urlencoded")
                myHttpRequestMessage.Content = AyehuHelper.formUrlEncodedContent(postData);
            else
              if (string.IsNullOrEmpty(postData) == false)
                if (omitJsonEmptyorNull)
                    myHttpRequestMessage.Content = new StringContent(AyehuHelper.omitJsonEmptyorNull(postData), Encoding.UTF8, "application/json");
                else
                    myHttpRequestMessage.Content = new StringContent(postData, Encoding.UTF8, "application/json");


            foreach (KeyValuePair<string, string> headeritem in headers)
                client.DefaultRequestHeaders.Add(headeritem.Key, headeritem.Value);

            HttpResponseMessage response = client.SendAsync(myHttpRequestMessage).Result;

            switch (response.StatusCode)
            {
                case HttpStatusCode.NoContent:
                case HttpStatusCode.Created:
                case HttpStatusCode.Accepted:
                case HttpStatusCode.OK:
                    {
                        if (string.IsNullOrEmpty(response.Content.ReadAsStringAsync().Result) == false)
                            return this.GenerateActivityResult(response.Content.ReadAsStringAsync().Result, Jsonkeypath);
                        else
                            return this.GenerateActivityResult("Success");
                    }
                default:
                    {
                        if (string.IsNullOrEmpty(response.Content.ReadAsStringAsync().Result) == false)
                            throw new Exception(response.Content.ReadAsStringAsync().Result);
                        else if (string.IsNullOrEmpty(response.ReasonPhrase) == false)
                            throw new Exception(response.ReasonPhrase);
                        else
                            throw new Exception(response.StatusCode.ToString());
                    }
            }
        }

        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}