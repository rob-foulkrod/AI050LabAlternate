# AI-050 Sandbox Emulator

This app is designed to be a Trainer assist when teaching AI-050.


## Deploy the solution

### 1. Select Deploy to Azure

This will launch a custom template for the Azure portal instance that you are logged into.

<a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Frob-foulkrod%2FAI050LabAlternate%2Fmain%2FAzureDeploy.json" target="_blank"><img src="https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/1-CONTRIBUTION-GUIDE/images/deploytoazure.svg?sanitize=true"/></a>

### 2. Configure with your Azure OpenAI configuration

You will need to set 4 configuration values to match your open AI deployment:

```json
[
  {
    "name": "OpenAI__DeploymentName",
    "value": "<yourDeploymentName>",
    "slotSetting": false
  },
  {
    "name": "OpenAI__Key",
    "value": "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
    "slotSetting": false
  },
  {
    "name": "OpenAI__Uri",
    "value": "https://<yourDeployment>.openai.azure.com/",
    "slotSetting": false
  },
  {
    "name": "OpenAI__Version",
    "value": "2023-07-01-preview",
    "slotSetting": false
  }
]
```
### Once you have configured the search service for Lab 6, you will need to update webapps' configuration values:

    You will need to add 
    - OpenAI__SearchEndpoint
    - OpenAI__SearchIndexName
    - OpenAI__SearchKey
   
   The values can be easily from from the OpanAI sandbox when you view code. It will look similar to the location below:

```json
[
  {
    "name": "OpenAI__DeploymentName",
    "value": "<yourDeploymentName>",
    "slotSetting": false
  },
  {
    "name": "OpenAI__Key",
    "value": "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
    "slotSetting": false
  },
  {
    "name": "OpenAI__Uri",
    "value": "https://<yourDeployment>.openai.azure.com/",
    "slotSetting": false
  },
  {
    "name": "OpenAI__Version",
    "value": "2023-07-01-preview",
    "slotSetting": false
  },
  {
    "name": "OpenAI__SearchEndpoint",
    "value": "https://<yourSearchName>.search.windows.net",
    "slotSetting": false
  },
  {
    "name": "OpenAI__SearchIndexName",
    "value": "margiestravel",
    "slotSetting": false
  },
  {
    "name": "OpenAI__SearchKey",
    "value": "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
    "slotSetting": false
  }
]
```

Once the search parameters are configured, the app will display the 'Use Custom Data Source' option on the Sandbox Lite page.


Remember to delete the resources after class to avoid charges.
