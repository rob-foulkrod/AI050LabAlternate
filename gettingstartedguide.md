## Azure OpenAI Sandbox Emulator 

GitHub Repo: https://github.com/rob-foulkrod/AI050LabAlternate  

## Step 1: 

Click on “Deploy to Azure” 

![image](https://github.com/VincentK16/AI050LabAlternate/assets/3338753/68ad26e0-7efd-4e25-952a-f8cf4928d39c)

## Step 2:  

Fill up the information for the custom deployment.  
![image](https://github.com/VincentK16/AI050LabAlternate/assets/3338753/04cc81ee-3ca5-411a-8f27-08cdf9883069)

## Step 3:  

Once deployed, browse to the <Resource Group> à App Service and update the Configuration 

![image](https://github.com/VincentK16/AI050LabAlternate/assets/3338753/3af8ca02-b674-44ac-b996-21fb55a93986)

Copy the configuration into the App Service configuration by going to Configuration -> Advance edit and paste it. 
<img width="427" alt="image" src="https://github.com/VincentK16/AI050LabAlternate/assets/3338753/11283220-2779-4cc2-84d5-16e4d0690353">

## Step 4:  

Browse to the Web App, and you are ready to share the web app with the learners to give it a try 😊 

![image](https://github.com/VincentK16/AI050LabAlternate/assets/3338753/353d2463-c11c-44eb-8be8-7cddda7b9e10)


## Bonus:  

Use your own data with Azure OpenAI 

Once you have added the data to the Azure OpenAI studio, you will have your Azure AI Search configuration, you will need to update webapps' configuration values: 

You will need to add  

- OpenAI__SearchEndpoint 

- OpenAI__SearchIndexName 

- OpenAI__SearchKey 

 

Once the Search parameters are configured, the app will display the 'Use Custom Data Source' option on the Sandbox Lite page. 
![image](https://github.com/VincentK16/AI050LabAlternate/assets/3338753/75d5cb87-1555-403d-858e-4fed7b39d326)

Remember to delete the resources after class to avoid charges. 

 

Big thanks to Rob Foulkrod for creating this alternate demo environment! 

## Additional (good to know notes): 
When you go to run it locally on your machine, you will need to do the equivalent of the app settings, this in found in the appsettings.Development.json file. 
