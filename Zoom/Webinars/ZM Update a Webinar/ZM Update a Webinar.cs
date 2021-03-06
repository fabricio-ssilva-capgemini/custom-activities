using System;
using Ayehu.Sdk.ActivityCreation.Interfaces;
using Ayehu.Sdk.ActivityCreation.Extension;
using Ayehu.Sdk.ActivityCreation.Helpers;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Collections.Generic;

namespace Ayehu.Zoom
{
    public class ZM_Update_a_Webinar : IActivityAsync
    {


    
    public string Jsonkeypath = "";
    
    public string apikey = "";
    
    public string password1 = "";
    
    public string webinarId = "";
    
    public string topic = "";
    
    public string type_p = "";
    
    public string start_time = "";
    
    public string duration = "";
    
    public string timezone = "";
    
    public string password = "";
    
    public string agenda = "";
    
    public string tracking_fields = "";
    
    public string recurrence_type = "";
    
    public string repeat_interval = "";
    
    public string weekly_days = "";
    
    public string monthly_day = "";
    
    public string monthly_week = "";
    
    public string monthly_week_day = "";
    
    public string end_times = "";
    
    public string end_date_time = "";
    
    private bool omitJsonEmptyorNull = true;
    
    private string contentType = "application/json";
    
    private string endPoint = "https://api.zoom.us";
    
    private string httpMethod = "PATCH";
    
    private string _uriBuilderPath;
    
    private string _postData;
    
    private System.Collections.Generic.Dictionary<string, string> _headers;
    
    private System.Collections.Generic.Dictionary<string, string> _queryStringArray;
    
    private string uriBuilderPath {
        get {
            if (string.IsNullOrEmpty(_uriBuilderPath)) {
_uriBuilderPath = string.Format("v2/webinars/{0}",webinarId);
            }
return _uriBuilderPath;
        }
        set {
            this._uriBuilderPath = value;
        }
    }
    
    private string postData {
        get {
            if (string.IsNullOrEmpty(_postData)) {
_postData = string.Format("{{ \"topic\": \"{0}\",  \"type\": \"{1}\",  \"start_time\": \"{2}\",  \"duration\": \"{3}\",  \"timezone\": \"{4}\",  \"password\": \"{5}\",  \"agenda\": \"{6}\",  \"tracking_fields\": {7},  \"recurrence\": {{   \"type\": \"{8}\",    \"repeat_interval\": \"{9}\",    \"weekly_days\": \"{10}\",    \"monthly_day\": \"{11}\",    \"monthly_week\": \"{12}\",    \"monthly_week_day\": \"{13}\",    \"end_times\": \"{14}\",    \"end_date_time\": \"{15}\"   }} }}",topic,type_p,start_time,duration,timezone,password,agenda,tracking_fields,recurrence_type,repeat_interval,weekly_days,monthly_day,monthly_week,monthly_week_day,end_times,end_date_time);
            }
return _postData;
        }
        set {
            this._postData = value;
        }
    }
    
    private System.Collections.Generic.Dictionary<string, string> headers {
        get {
            if (_headers == null) {
_headers = new Dictionary<string, string>() { {"authorization","Bearer " + AyehuHelper.JWTToken(apikey,password1,"HS256","JWT", 120)} };
            }
return _headers;
        }
        set {
            this._headers = value;
        }
    }
    
    private System.Collections.Generic.Dictionary<string, string> queryStringArray {
        get {
            if (_queryStringArray == null) {
_queryStringArray = new Dictionary<string, string>() {  };
            }
return _queryStringArray;
        }
        set {
            this._queryStringArray = value;
        }
    }
    
    public ZM_Update_a_Webinar() {
    }
    
    public ZM_Update_a_Webinar(
                string Jsonkeypath, 
                string apikey, 
                string password1, 
                string webinarId, 
                string topic, 
                string type_p, 
                string start_time, 
                string duration, 
                string timezone, 
                string password, 
                string agenda, 
                string tracking_fields, 
                string recurrence_type, 
                string repeat_interval, 
                string weekly_days, 
                string monthly_day, 
                string monthly_week, 
                string monthly_week_day, 
                string end_times, 
                string end_date_time) {
        this.Jsonkeypath = Jsonkeypath;
        this.apikey = apikey;
        this.password1 = password1;
        this.webinarId = webinarId;
        this.topic = topic;
        this.type_p = type_p;
        this.start_time = start_time;
        this.duration = duration;
        this.timezone = timezone;
        this.password = password;
        this.agenda = agenda;
        this.tracking_fields = tracking_fields;
        this.recurrence_type = recurrence_type;
        this.repeat_interval = repeat_interval;
        this.weekly_days = weekly_days;
        this.monthly_day = monthly_day;
        this.monthly_week = monthly_week;
        this.monthly_week_day = monthly_week_day;
        this.end_times = end_times;
        this.end_date_time = end_date_time;
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
                    myHttpRequestMessage.Content = new StringContent(postData, Encoding.UTF8, contentType);


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