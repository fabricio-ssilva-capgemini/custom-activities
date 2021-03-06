## GCloudCreateNetwork - Create Network in Google Cloud.

Remark - To create a network in Google Cloud you need to set-up a new Service Account at https://cloud.google.com. Check this [tutorial](https://docs.bmc.com/docs/PATROL4GoogleCloudPlatform/10/creating-a-service-account-key-in-the-google-cloud-platform-project-799095477.html).  

##### DLL's to reference
Google.Apis.Auth.dll  
Google.Apis.Auth.PlatformServices.dll  
Google.Apis.Compute.v1.dll  
Google.Apis.Core.dll  
Google.Apis.dll  
Google.Apis.PlatformServices.dll  
Newtonsoft.Json.dll  

You can find the dll's at [nuget](https://www.nuget.org/packages/Google.Apis.Compute.v1).

##### Libraries to import
using Ayehu.Sdk.ActivityCreation.Interfaces;  
using Ayehu.Sdk.ActivityCreation.Extension;  
using System;  
using System.Collections.Generic;  
using Google.Apis.Services;  
using Google.Apis.Compute.v1;  
using Google.Apis.Auth.OAuth2;  
using Google.Apis.Compute.v1.Data;  
using System.Threading.Tasks;  
using System.Text;  

### Mandatory fields when creating a network:
**Project**				- The name of the Google Cloud Project you are working on (e.g.,  peak-equator-254518)  
**NetworkName**			- Network name to be created  
**RoutingMode**			- Routing mode of the network (REGIONAL or GLOBAL)  
**ServiceAccountEmail**	- Service Account E-mail. You can create one following this [tutorial](https://docs.bmc.com/docs/PATROL4GoogleCloudPlatform/10/creating-a-service-account-key-in-the-google-cloud-platform-project-799095477.html)  
**PrivateKey**			- When creating a service account, you will be able to donwload a JSON file. Inside the file you can get the private key for the chosen service Account  