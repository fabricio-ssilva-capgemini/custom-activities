<br>#     Ayehu</br>
<br>AY SelfServiceCreateForm</br>
<br>Method: Post</br>
<br>OperationID: SelfService_CreateForm</br>
<br>EndPoint:</br>
<br>/Api/selfService/createForm</br>
<br>Usage: tags[]</br>
<br>[{
  "id": "%tags_id%",
  "name": "%tags_name%",
  "description": "%description%"
}]</br>
<br>Usage: permissions[]</br>
<br>[{
  "type": "%type%",
  "number": "%number%",
  "name": "%permissions_name%",
  "read": "%read%",
  "write": "%write%",
  "run": "%run%",
  "owner": "%owner%"
}]</br>
<br>Usage: formControls[]</br>
<br>[{
  "variableName": "%variableName%",
  "variableId": "%variableId%",
  "workflowId": "%formControls_workflowId%",
  "workflowName": "%workflowName%",
  "id": "%formControls_id%",
  "selected": "%selected%",
  "rightToLeft": "%rightToLeft%",
  "maxLength": "%maxLength%",
  "name": "%formControls_name%",
  "toolbarModel": {
    "data": {
      "bold": "%bold%",
      "italic": "%italic%",
      "underline": "%underline%",
      "color": "%color%",
      "font": "%font%",
      "size": "%size%",
      "strike": "%strike%"
    }
  }
}]</br>
