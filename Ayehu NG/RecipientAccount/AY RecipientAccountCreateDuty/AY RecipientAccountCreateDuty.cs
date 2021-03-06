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
    public class CustomActivity_AY_RecipientAccountCreateDuty : IActivityAsync
    {


    
    public string endPoint = "https://{hostname}:8442";
    
    public string Jsonkeypath = "createDuty";
    
    public string password1 = "";
    
    public string duty = "";
    
    public string id_p = "";
    
    public string name_p = "";
    
    public string Ddescp = "";
    
    public string Site = "";
    
    public string DutyTimeFramesNumber = "";
    
    public string FollowTheSun = "";
    
    public string ObjectNumber = "";
    
    public string UseWhenShiftMissing = "";
    
    public string AlwaysUseThisContact = "";
    
    public string DutySupervisors__ = "";
    
    public string accountId = "";
    
    public string userName = "";
    
    public string activeDirectoryId = "";
    
    public string DefaultContactUserName = "";
    
    public string DefaultUserType = "";
    
    public string totalRecords = "";
    
    private bool omitJsonEmptyorNull = true;
    
    private string contentType = "application/json";
    
    private string httpMethod = "POST";
    
    private string uriBuilderPath {
        get {
            return "Server/Api/recipients/createDuty";
        }
    }
    
    private string postData {
        get {
            return string.Format("{{ \"id\": \"{0}\",  \"name\": \"{1}\",  \"Ddescp\": \"{2}\",  \"Site\": \"{3}\",  \"DutyTimeFramesNumber\": \"{4}\",  \"FollowTheSun\": \"{5}\",  \"ObjectNumber\": \"{6}\",  \"UseWhenShiftMissing\": \"{7}\",  \"AlwaysUseThisContact\": \"{8}\",  \"DutySupervisors\": [    {{     \"accountId\": \"{9}\",      \"userName\": \"{10}\",      \"activeDirectoryId\": \"{11}\"     }}  ],  \"DefaultContactUserName\": \"{12}\",  \"DefaultUserType\": \"{13}\",  \"totalRecords\": \"{14}\" }}",id_p,name_p,Ddescp,Site,DutyTimeFramesNumber,FollowTheSun,ObjectNumber,UseWhenShiftMissing,AlwaysUseThisContact,accountId,userName,activeDirectoryId,DefaultContactUserName,DefaultUserType,totalRecords);
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