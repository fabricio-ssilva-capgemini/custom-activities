<br>#     Zoom</br>
<br>Update Zoom Room Account Settings</br>
<br>Update account settings applied for Zoom Rooms in a Zoom account. With this API, you can update either the **Account Meeting Settings** or the **Alert Settings** (Client Alert Settings and Notfication Settings) of the Zoom Rooms account by specifying the required setting type in the `setting_type` parameter. To update only **Alert Settings**, specify `alert` as the value of the `setting_type` query parameter and to update only **Account Meeting Settings**, specify `meeting` as the value of the `setting_type` query parameter.
**Prerequisites:**
* Zoom Room licenses
* Owner or Admin privileges on the Zoom Account.
**Scopes:** `room:write:admin` 

</br>
<br>Method: Patch</br>
<br>OperationID: updateZoomRoomAccSettings</br>
<br>EndPoint:</br>
<br>/rooms/account_settings</br>
