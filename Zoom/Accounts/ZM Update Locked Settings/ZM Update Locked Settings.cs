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
    public class ZM_Update_Locked_Settings : IActivityAsync
    {


    
    public string Jsonkeypath = "lock_settings";
    
    public string apikey = "";
    
    public string password1 = "";
    
    public string accountId = "";
    
    public string host_video = "";
    
    public string participant_video = "";
    
    public string audio_type = "";
    
    public string join_before_host = "";
    
    public string enforce_login = "";
    
    public string enforce_login_with_domains = "";
    
    public string enforce_login_domains = "";
    
    public string not_store_meeting_topic = "";
    
    public string require_password_for_scheduling_new_meetings = "";
    
    public string require_password_for_instant_meetings = "";
    
    public string require_password_for_pmi_meetings = "";
    
    public string meeting_authentication = "";
    
    public string e2e_encryption = "";
    
    public string chat = "";
    
    public string private_chat = "";
    
    public string auto_saving_chat = "";
    
    public string entry_exit_chime = "";
    
    public string feedback = "";
    
    public string post_meeting_feedback = "";
    
    public string co_host = "";
    
    public string polling = "";
    
    public string attendee_on_hold = "";
    
    public string show_meeting_control_toolbar = "";
    
    public string allow_show_zoom_windows = "";
    
    public string annotation = "";
    
    public string whiteboard = "";
    
    public string remote_control = "";
    
    public string webinar_question_answer = "";
    
    public string anonymous_question_answer = "";
    
    public string breakout_room = "";
    
    public string closed_caption = "";
    
    public string far_end_camera_control = "";
    
    public string group_hd = "";
    
    public string virtual_background = "";
    
    public string alert_guest_join = "";
    
    public string auto_answer = "";
    
    public string sending_default_email_invites = "";
    
    public string use_html_format_email = "";
    
    public string dscp_marking = "";
    
    public string stereo_audio = "";
    
    public string original_audio = "";
    
    public string screen_sharing = "";
    
    public string cloud_recording_available_reminder = "";
    
    public string jbh_reminder = "";
    
    public string cancel_meeting_reminder = "";
    
    public string alternative_host_reminder = "";
    
    public string schedule_for_host_reminder = "";
    
    public string local_recording = "";
    
    public string cloud_recording = "";
    
    public string auto_recording = "";
    
    public string cloud_recording_download = "";
    
    public string account_user_access_recording = "";
    
    public string host_delete_cloud_recording = "";
    
    public string auto_delete_cmr = "";
    
    public string recording_authentication = "";
    
    public string third_party_audio = "";
    
    public string call_out = "";
    
    public string show_international_numbers_link = "";
    
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
_uriBuilderPath = string.Format("v2/accounts/{0}/lock_settings",accountId);
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
_postData = string.Format("{{ \"schedule_meeting\": {{   \"host_video\": \"{0}\",    \"participant_video\": \"{1}\",    \"audio_type\": \"{2}\",    \"join_before_host\": \"{3}\",    \"enforce_login\": \"{4}\",    \"enforce_login_with_domains\": \"{5}\",    \"enforce_login_domains\": \"{6}\",    \"not_store_meeting_topic\": \"{7}\",    \"require_password_for_scheduling_new_meetings\": \"{8}\",    \"require_password_for_instant_meetings\": \"{9}\",    \"require_password_for_pmi_meetings\": \"{10}\",    \"meeting_authentication\": \"{11}\"   }},  \"in_meeting\": {{   \"e2e_encryption\": \"{12}\",    \"chat\": \"{13}\",    \"private_chat\": \"{14}\",    \"auto_saving_chat\": \"{15}\",    \"entry_exit_chime\": \"{16}\",    \"feedback\": \"{17}\",    \"post_meeting_feedback\": \"{18}\",    \"co_host\": \"{19}\",    \"polling\": \"{20}\",    \"attendee_on_hold\": \"{21}\",    \"show_meeting_control_toolbar\": \"{22}\",    \"allow_show_zoom_windows\": \"{23}\",    \"annotation\": \"{24}\",    \"whiteboard\": \"{25}\",    \"remote_control\": \"{26}\",    \"webinar_question_answer\": \"{27}\",    \"anonymous_question_answer\": \"{28}\",    \"breakout_room\": \"{29}\",    \"closed_caption\": \"{30}\",    \"far_end_camera_control\": \"{31}\",    \"group_hd\": \"{32}\",    \"virtual_background\": \"{33}\",    \"alert_guest_join\": \"{34}\",    \"auto_answer\": \"{35}\",    \"sending_default_email_invites\": \"{36}\",    \"use_html_format_email\": \"{37}\",    \"dscp_marking\": \"{38}\",    \"stereo_audio\": \"{39}\",    \"original_audio\": \"{40}\",    \"screen_sharing\": \"{41}\"   }},  \"email_notification\": {{   \"cloud_recording_available_reminder\": \"{42}\",    \"jbh_reminder\": \"{43}\",    \"cancel_meeting_reminder\": \"{44}\",    \"alternative_host_reminder\": \"{45}\",    \"schedule_for_host_reminder\": \"{46}\"   }},  \"recording\": {{   \"local_recording\": \"{47}\",    \"cloud_recording\": \"{48}\",    \"auto_recording\": \"{49}\",    \"cloud_recording_download\": \"{50}\",    \"account_user_access_recording\": \"{51}\",    \"host_delete_cloud_recording\": \"{52}\",    \"auto_delete_cmr\": \"{53}\",    \"recording_authentication\": \"{54}\"   }},  \"telephony\": {{   \"third_party_audio\": \"{55}\"   }},  \"tsp\": {{   \"call_out\": \"{56}\",    \"show_international_numbers_link\": \"{57}\"   }} }}",host_video,participant_video,audio_type,join_before_host,enforce_login,enforce_login_with_domains,enforce_login_domains,not_store_meeting_topic,require_password_for_scheduling_new_meetings,require_password_for_instant_meetings,require_password_for_pmi_meetings,meeting_authentication,e2e_encryption,chat,private_chat,auto_saving_chat,entry_exit_chime,feedback,post_meeting_feedback,co_host,polling,attendee_on_hold,show_meeting_control_toolbar,allow_show_zoom_windows,annotation,whiteboard,remote_control,webinar_question_answer,anonymous_question_answer,breakout_room,closed_caption,far_end_camera_control,group_hd,virtual_background,alert_guest_join,auto_answer,sending_default_email_invites,use_html_format_email,dscp_marking,stereo_audio,original_audio,screen_sharing,cloud_recording_available_reminder,jbh_reminder,cancel_meeting_reminder,alternative_host_reminder,schedule_for_host_reminder,local_recording,cloud_recording,auto_recording,cloud_recording_download,account_user_access_recording,host_delete_cloud_recording,auto_delete_cmr,recording_authentication,third_party_audio,call_out,show_international_numbers_link);
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
    
    public ZM_Update_Locked_Settings() {
    }
    
    public ZM_Update_Locked_Settings(
                string Jsonkeypath, 
                string apikey, 
                string password1, 
                string accountId, 
                string host_video, 
                string participant_video, 
                string audio_type, 
                string join_before_host, 
                string enforce_login, 
                string enforce_login_with_domains, 
                string enforce_login_domains, 
                string not_store_meeting_topic, 
                string require_password_for_scheduling_new_meetings, 
                string require_password_for_instant_meetings, 
                string require_password_for_pmi_meetings, 
                string meeting_authentication, 
                string e2e_encryption, 
                string chat, 
                string private_chat, 
                string auto_saving_chat, 
                string entry_exit_chime, 
                string feedback, 
                string post_meeting_feedback, 
                string co_host, 
                string polling, 
                string attendee_on_hold, 
                string show_meeting_control_toolbar, 
                string allow_show_zoom_windows, 
                string annotation, 
                string whiteboard, 
                string remote_control, 
                string webinar_question_answer, 
                string anonymous_question_answer, 
                string breakout_room, 
                string closed_caption, 
                string far_end_camera_control, 
                string group_hd, 
                string virtual_background, 
                string alert_guest_join, 
                string auto_answer, 
                string sending_default_email_invites, 
                string use_html_format_email, 
                string dscp_marking, 
                string stereo_audio, 
                string original_audio, 
                string screen_sharing, 
                string cloud_recording_available_reminder, 
                string jbh_reminder, 
                string cancel_meeting_reminder, 
                string alternative_host_reminder, 
                string schedule_for_host_reminder, 
                string local_recording, 
                string cloud_recording, 
                string auto_recording, 
                string cloud_recording_download, 
                string account_user_access_recording, 
                string host_delete_cloud_recording, 
                string auto_delete_cmr, 
                string recording_authentication, 
                string third_party_audio, 
                string call_out, 
                string show_international_numbers_link) {
        this.Jsonkeypath = Jsonkeypath;
        this.apikey = apikey;
        this.password1 = password1;
        this.accountId = accountId;
        this.host_video = host_video;
        this.participant_video = participant_video;
        this.audio_type = audio_type;
        this.join_before_host = join_before_host;
        this.enforce_login = enforce_login;
        this.enforce_login_with_domains = enforce_login_with_domains;
        this.enforce_login_domains = enforce_login_domains;
        this.not_store_meeting_topic = not_store_meeting_topic;
        this.require_password_for_scheduling_new_meetings = require_password_for_scheduling_new_meetings;
        this.require_password_for_instant_meetings = require_password_for_instant_meetings;
        this.require_password_for_pmi_meetings = require_password_for_pmi_meetings;
        this.meeting_authentication = meeting_authentication;
        this.e2e_encryption = e2e_encryption;
        this.chat = chat;
        this.private_chat = private_chat;
        this.auto_saving_chat = auto_saving_chat;
        this.entry_exit_chime = entry_exit_chime;
        this.feedback = feedback;
        this.post_meeting_feedback = post_meeting_feedback;
        this.co_host = co_host;
        this.polling = polling;
        this.attendee_on_hold = attendee_on_hold;
        this.show_meeting_control_toolbar = show_meeting_control_toolbar;
        this.allow_show_zoom_windows = allow_show_zoom_windows;
        this.annotation = annotation;
        this.whiteboard = whiteboard;
        this.remote_control = remote_control;
        this.webinar_question_answer = webinar_question_answer;
        this.anonymous_question_answer = anonymous_question_answer;
        this.breakout_room = breakout_room;
        this.closed_caption = closed_caption;
        this.far_end_camera_control = far_end_camera_control;
        this.group_hd = group_hd;
        this.virtual_background = virtual_background;
        this.alert_guest_join = alert_guest_join;
        this.auto_answer = auto_answer;
        this.sending_default_email_invites = sending_default_email_invites;
        this.use_html_format_email = use_html_format_email;
        this.dscp_marking = dscp_marking;
        this.stereo_audio = stereo_audio;
        this.original_audio = original_audio;
        this.screen_sharing = screen_sharing;
        this.cloud_recording_available_reminder = cloud_recording_available_reminder;
        this.jbh_reminder = jbh_reminder;
        this.cancel_meeting_reminder = cancel_meeting_reminder;
        this.alternative_host_reminder = alternative_host_reminder;
        this.schedule_for_host_reminder = schedule_for_host_reminder;
        this.local_recording = local_recording;
        this.cloud_recording = cloud_recording;
        this.auto_recording = auto_recording;
        this.cloud_recording_download = cloud_recording_download;
        this.account_user_access_recording = account_user_access_recording;
        this.host_delete_cloud_recording = host_delete_cloud_recording;
        this.auto_delete_cmr = auto_delete_cmr;
        this.recording_authentication = recording_authentication;
        this.third_party_audio = third_party_audio;
        this.call_out = call_out;
        this.show_international_numbers_link = show_international_numbers_link;
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