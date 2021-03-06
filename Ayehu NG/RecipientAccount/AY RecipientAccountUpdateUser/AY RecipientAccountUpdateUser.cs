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
    public class CustomActivity_AY_RecipientAccountUpdateUser : IActivityAsync
    {


    
    public string endPoint = "https://{hostname}:8442";
    
    public string Jsonkeypath = "updateUser";
    
    public string password1 = "";
    
    public string userModel = "";
    
    public string id_p = "";
    
    public string name_p = "";
    
    public string fName = "";
    
    public string lName = "";
    
    public string email = "";
    
    public string mobilePhoneNumber = "";
    
    public string roleId = "";
    
    public string roleName = "";
    
    public string password = "";
    
    public string activeDirectoryId = "";
    
    public string ayehuIm = "";
    
    public string employeeNumber = "";
    
    public string userGroups__ = "";
    
    public string userGroups_id = "";
    
    public string userGroups_name = "";
    
    public string userGroupDescription = "";
    
    public string site = "";
    
    public string userGroups_activeDirectoryId = "";
    
    public string owners__ = "";
    
    public string owners_activeDirectoryId = "";
    
    public string userGroupId = "";
    
    public string owners_name = "";
    
    public string owners_id = "";
    
    public string groupMembers__ = "";
    
    public string permissionType = "";
    
    public string orderIndex = "";
    
    public string groupMembers_activeDirectoryId = "";
    
    public string groupMembers_userGroupId = "";
    
    public string groupMembers_name = "";
    
    public string groupMembers_id = "";
    
    public string ownersString = "";
    
    public string totalRecords = "";
    
    public string userGroups_roleId = "";
    
    public string userGroups_roleName = "";
    
    public string rolePriority = "";
    
    public string userGroupType = "";
    
    public string domainId = "";
    
    public string domainName = "";
    
    public string _domainId = "";
    
    public string _domainName = "";
    
    public string isPasswordEncrypted = "";
    
    private bool omitJsonEmptyorNull = true;
    
    private string contentType = "application/json";
    
    private string httpMethod = "POST";
    
    private string uriBuilderPath {
        get {
            return "Server/Api/recipients/updateUser";
        }
    }
    
    private string postData {
        get {
            return string.Format("{{ \"id\": \"{0}\",  \"name\": \"{1}\",  \"fName\": \"{2}\",  \"lName\": \"{3}\",  \"email\": \"{4}\",  \"mobilePhoneNumber\": \"{5}\",  \"roleId\": \"{6}\",  \"roleName\": \"{7}\",  \"password\": \"{8}\",  \"activeDirectoryId\": \"{9}\",  \"ayehuIm\": \"{10}\",  \"employeeNumber\": \"{11}\",  \"userGroups\": [    {{     \"id\": \"{12}\",      \"name\": \"{13}\",      \"userGroupDescription\": \"{14}\",      \"site\": \"{15}\",      \"activeDirectoryId\": \"{16}\",      \"owners\": [        {{         \"activeDirectoryId\": \"{17}\",          \"userGroupId\": \"{18}\",          \"name\": \"{19}\",          \"id\": \"{20}\"         }}      ],      \"groupMembers\": [        {{         \"permissionType\": \"{21}\",          \"orderIndex\": \"{22}\",          \"activeDirectoryId\": \"{23}\",          \"userGroupId\": \"{24}\",          \"name\": \"{25}\",          \"id\": \"{26}\"         }}      ],      \"ownersString\": \"{27}\",      \"totalRecords\": \"{28}\",      \"roleId\": \"{29}\",      \"roleName\": \"{30}\",      \"rolePriority\": \"{31}\",      \"userGroupType\": \"{32}\",      \"domainId\": \"{33}\",      \"domainName\": \"{34}\"     }}  ],  \"domainId\": \"{35}\",  \"domainName\": \"{36}\",  \"isPasswordEncrypted\": \"{37}\" }}",id_p,name_p,fName,lName,email,mobilePhoneNumber,roleId,roleName,password,activeDirectoryId,ayehuIm,employeeNumber,userGroups_id,userGroups_name,userGroupDescription,site,userGroups_activeDirectoryId,owners_activeDirectoryId,userGroupId,owners_name,owners_id,permissionType,orderIndex,groupMembers_activeDirectoryId,groupMembers_userGroupId,groupMembers_name,groupMembers_id,ownersString,totalRecords,userGroups_roleId,userGroups_roleName,rolePriority,userGroupType,domainId,domainName,_domainId,_domainName,isPasswordEncrypted);
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