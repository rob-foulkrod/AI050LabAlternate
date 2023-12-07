namespace AI050LabAlternate.Data
{
    public class OpenAIConfig
    {

        public string OpenAIURI { get; set; } = AzureOpenAIEndpointDefault;
        public string OpenAIKey { get; set; } = AzureOpenAIKeyDefault;
        public string DeploymentName{ get; set; } = "";
        public string Version { get; set; } = "";
        public string SearchEndpoint { get; set; } = "";
        public string SearchKey { get; set; } = "";
        public string SearchIndexName { get; set; } = "";

        //Assigned in the startup process due to validating
        public bool OpenAIConfigured => OpenAIURI != AzureOpenAIEndpointDefault && OpenAIKey != AzureOpenAIKeyDefault
            && !string.IsNullOrEmpty(DeploymentName) && !string.IsNullOrEmpty(Version);
            


        public bool SearchConfigured => !string.IsNullOrEmpty(SearchEndpoint) && !string.IsNullOrEmpty(SearchKey) && !string.IsNullOrEmpty(SearchIndexName);


        public static string AzureOpenAIEndpointDefault => "https://example.com";
        public static string AzureOpenAIKeyDefault => "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
    }
}
