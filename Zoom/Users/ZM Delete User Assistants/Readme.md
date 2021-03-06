<br>#     Zoom</br>
<br>Delete User Assistants</br>
<br>Delete all assistants of the current user. Assistants are the users to whom the current user has assigned [scheduling privilege](https://support.zoom.us/hc/en-us/articles/201362803-Scheduling-Privilege). These assistants can schedule meeting on behalf of the current user as well as manage and act as an alternative host for all meetings if the admin has enabled [Co-host option](https://zoom.us/account/setting) on the account.
**Prerequisite**: 
* The user as well as the assistant must have Licensed or an On-prem license.
* Assistants must be under the current user's account.
**Scopes**: `user:write:admin` `user:write`
 </br>
<br>Method: Delete</br>
<br>OperationID: userAssistantsDelete</br>
<br>EndPoint:</br>
<br>/users/{userId}/assistants</br>
