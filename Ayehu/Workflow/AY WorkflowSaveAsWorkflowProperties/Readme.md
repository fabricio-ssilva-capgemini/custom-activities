<br>#     Ayehu</br>
<br>AY WorkflowSaveAsWorkflowProperties</br>
<br>Method: Put</br>
<br>OperationID: Workflow_SaveAsWorkflowProperties</br>
<br>EndPoint:</br>
<br>/Api/workflow/saveAsWorkflowProperties</br>
<br>Usage: errorHandling[]</br>
<br>[{
  "id": "%id%",
  "name": "%name%",
  "description": "%description%",
  "applyForAllWorkflows": "%applyForAllWorkflows%",
  "usedInWorkflows": "%usedInWorkflows%"
}]</br>
<br>Usage: tags[]</br>
<br>[{
  "description": "%tags_description%",
  "id": "%tags_id%",
  "name": "%tags_name%"
}]</br>
<br>Usage: allPermissions[]</br>
<br>[{
  "canRead": "%allPermissions_canRead%",
  "canRun": "%allPermissions_canRun%",
  "canWrite": "%allPermissions_canWrite%",
  "isOwner": "%allPermissions_isOwner%",
  "permissionTypeEntityName": "%allPermissions_permissionTypeEntityName%",
  "permissionTypeEntityNumber": "%allPermissions_permissionTypeEntityNumber%",
  "permissionTypeId": "%allPermissions_permissionTypeId%"
}]</br>
