<br>#     Zoom</br>
<br>Cancel Base Plan</br>
<br>[Cancel a base plan](https://support.zoom.us/hc/en-us/articles/203634215-How-Do-I-Cancel-My-Subscription-) for a sub account.
  Only a Master Account can use this API to cancel the base plan of a Sub Account whose billing charges are paid by the Master Account. Zoom only assigns this privilege to trusted partners and only approved partners can use this API. Contact the [**ISV team**](https://zoom.us/plan/api) for more details.

**Scopes**: `billing:master`
**Prerequisites:**
* The Sub Account must have a Pro or a higher plan.
 </br>
<br>Method: Patch</br>
<br>OperationID: accountPlanBaseDelete</br>
<br>EndPoint:</br>
<br>/accounts/{accountId}/plans/base/status</br>
